using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;
using EnvDTE;
using LinqToSalesforce.VsPlugin2017.Annotations;
using LinqToSalesforce.VsPlugin2017.Helpers;
using LinqToSalesforce.VsPlugin2017.Model;
using LinqToSalesforce.VsPlugin2017.Storage;
using Microsoft.FSharp.Control;
using Microsoft.FSharp.Core;
using Microsoft.VisualStudio.Shell;
using MessageBox = System.Windows.MessageBox;
using Task = System.Threading.Tasks.Task;

namespace LinqToSalesforce.VsPlugin2017.ViewModels
{
    public class TablesSelectViewModel : INotifyPropertyChanged
    {
        static readonly object locker = new object();

        private readonly DTE dte;
        private readonly Dispatcher dispatcher;
        private readonly IDiagramDocumentStorage documentStorage;
        private bool allChecked;
        private string sourceCode;

        public TablesSelectViewModel(DTE dte, Dispatcher dispatcher, IDiagramDocumentStorage documentStorage,
            DiagramDocument document, string filename, Rest.OAuth.Identity identity)
        {
            this.dte = dte;
            this.dispatcher = dispatcher;
            this.documentStorage = documentStorage;
            Document = document;
            Filename = filename;
            Identity = identity;

            Tables = new ObservableCollection<TableDescPresenter>();
            allChecked = false;
        }

        public DiagramDocument Document { get; }

        public string Filename { get; }

        public string SourceCode
        {
            get { return sourceCode; }
            set
            {
                sourceCode = value;
                OnPropertyChanged();
            }
        }

        public Rest.OAuth.Identity Identity { get; }

        public ObservableCollection<TableDescPresenter> Tables { get; set; }

        public ICommand SaveCommand => new RelayCommand(() =>
        {
            GenerateSourceCode();
        });

        private void SaveGeneratedCode()
        {
            lock (locker)
            {
                var csFullPath = CsFullPath;
                File.WriteAllText(csFullPath, SourceCode);

                var activeSolutionProjects = (Array) dte.ActiveSolutionProjects;
                if (activeSolutionProjects.Length <= 0)
                {
                    //MessageBox.Show("Please select a project in the Solution Explorer.");
                    return;
                }
                var project = (Project) activeSolutionProjects.GetValue(0);
                var fileNames = project.GetProjectFiles().ToArray();

                if (fileNames.All(f => f.FileNames[0] != csFullPath))
                {
                    var item = fileNames.First(f => f.FileNames[0] == Filename);
                    item.ProjectItems.AddFromFile(csFullPath);
                }

                project.Save();

                
            }
        }

        private string CsFullPath
        {
            get
            {
                var dir = Path.GetDirectoryName(Filename);
                var csFilename = Path.GetFileNameWithoutExtension(Filename) + ".generated.cs";
                var csFullPath = Path.Combine(dir, csFilename);
                return csFullPath;
            }
        }

        public Project Project
        {
            get
            {
                var activeSolutionProjects = (Array)dte.ActiveSolutionProjects;
                if (activeSolutionProjects.Length <= 0)
                    return null;

                return (Project)activeSolutionProjects.GetValue(0);
            }
        }
        
        public bool AllChecked
        {
            get { return allChecked; }
            set
            {
                allChecked = value;
                foreach (var table in Tables)
                {
                    table.Selected = allChecked;
                }
                
                OnPropertyChanged();
            }
        }

        public void GenerateSourceCode()
        {
            var nameSpace = ResolveNameSpace();

            UnsubscribeTablePresenters();
            Task.Factory.StartNew(() =>
            {
                var selectedTables = Tables.Where(t => t.Selected).Select(t => t.Table).ToArray();
                var csharp = CodeGeneration.generateCsharp(selectedTables, nameSpace);

                dispatcher.InvokeAsync(() =>
                {
                    SourceCode = csharp;
                });

                SubscribeTablePresenters();
                if (Tables.Any())
                {
                    Document.Tables = Tables.Select(t => t.Table.Name).ToArray();
                    Document.SelectedTables = selectedTables.Select(t => t.Name).ToArray();
                    documentStorage.Save(Document, Filename);
                }
                
                SaveGeneratedCode();
            });
        }

        public void ViewCode()
        {
            foreach (var project in dte.GetSolutionProjects())
            {
                TryOpenGeneratedCsFile(project);
            }

            
        }

        private void TryOpenGeneratedCsFile(Project project)
        {
            var item = project?.GetProjectFiles()?.FirstOrDefault(i => i.FileNames[0] == Filename);
            if (item != null)
            {
                foreach (ProjectItem projectItem in item.ProjectItems)
                {
                    if (projectItem.FileNames[0] == CsFullPath)
                    {
                        CheckNuget(project);

                        if (projectItem.IsOpen)
                            continue;
                        var window = projectItem.Open();
                        window.Visible = true;
                        window.SetFocus();
                    }
                }
            }
        }

        private static void CheckNuget(Project project)
        {
            var references = project.GetReferences().ToArray();
            if (references.All(r => r.Name != "LinqToSalesforce"))
            {
                MessageBox.Show("NuGet LinqToSalesforce should be added to project.");
                VsShellUtilities.OpenBrowser("https://www.nuget.org/packages/LinqToSalesforce");
            }
        }

        public string ResolveNameSpace()
        {
            var activeSolutionProjects = (Array)dte.ActiveSolutionProjects;
            if (activeSolutionProjects.Length <= 0)
                return "LinqToSalesforce";

            var project = (Project)activeSolutionProjects.GetValue(0);
            var defaultNamespace = project.Properties.Item("DefaultNamespace").Value;

            return defaultNamespace.ToString();
        }

        public void LoadTables()
        {
            Task.Factory.StartNew(async () =>
            {
                var tableDescs = await GetTableListAsync();
                dispatcher.Invoke(() =>
                {
                    UnsubscribeTablePresenters();
                    Tables.Clear();

                    foreach (var tableDesc in tableDescs)
                    {
                        var selected = Document?.SelectedTables?.Contains(tableDesc.Name) ?? false;
                        var presenter = new TableDescPresenter
                        {
                            Selected = selected,
                            Table = tableDesc
                        };
                        Tables.Add(presenter);
                    }

                    allChecked = Document?.SelectedTables?.SequenceEqual(Document?.Tables ?? Enumerable.Empty<string>()) ?? false;
                    OnPropertyChanged(nameof(AllChecked));

                    SubscribeTablePresenters();
                });
            });
        }

        private void SubscribeTablePresenters()
        {
            foreach (var table in Tables)
                table.PropertyChanged += PresenterOnPropertyChanged;
        }

        private void UnsubscribeTablePresenters()
        {
            foreach (var table in Tables)
                table.PropertyChanged -= PresenterOnPropertyChanged;
        }

        private void PresenterOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            
        }

        private async Task<IEnumerable<Rest.TableDesc>> GetTableListAsync()
        {
            Action<string> logger = s =>
            {
                Console.WriteLine(s);
            };

            Rest.Config.ProductionInstance = Document.Credentials.Instance;

            return FSharpAsync.RunSynchronously(Rest.getObjectsList(Identity, logger), FSharpOption<int>.None,
                FSharpOption<CancellationToken>.None);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
