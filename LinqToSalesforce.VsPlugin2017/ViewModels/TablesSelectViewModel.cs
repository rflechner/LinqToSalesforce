using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;
using EnvDTE;
using LinqToSalesforce.VsPlugin2017.Annotations;
using LinqToSalesforce.VsPlugin2017.Model;
using LinqToSalesforce.VsPlugin2017.Storage;
using Microsoft.FSharp.Control;
using Microsoft.FSharp.Core;

namespace LinqToSalesforce.VsPlugin2017.ViewModels
{
    public class TableDescPresenter : INotifyPropertyChanged
    {
        private bool selected;

        public bool Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged();
            }
        }

        public Rest.TableDesc Table { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class TablesSelectViewModel : INotifyPropertyChanged
    {
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
            AllChecked = true;
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
            var activeSolutionProjects = (Array)dte.ActiveSolutionProjects;
            if (activeSolutionProjects.Length <= 0)
                return;

            var dir = Path.GetDirectoryName(Filename);
            var csFilename = Path.GetFileNameWithoutExtension(Filename) + ".generated.cs";
            var csFullPath = Path.Combine(dir, csFilename);
            var fileNames = GetProjectFiles().ToArray();

            File.WriteAllText(csFullPath, SourceCode);

            var project = (Project)activeSolutionProjects.GetValue(0);

            if (fileNames.All(f => f.FileNames[0] != csFullPath))
            {
                var item = fileNames.First(f => f.FileNames[0] == Filename);
                item.ProjectItems.AddFromFile(csFullPath);
            }

            project.Save();
        });

        public IEnumerable<ProjectItem> GetProjectFiles()
        {
            var activeSolutionProjects = (Array)dte.ActiveSolutionProjects;
            if (activeSolutionProjects.Length <= 0)
                yield break;

            var project = (Project)activeSolutionProjects.GetValue(0);

            foreach (var p in project.Collection)
            {
                var proj = (Project)p;
                foreach (var sp in proj.ProjectItems)
                {
                    yield return (ProjectItem)sp;
                }
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
                
                GenerateSourceCode();
            }
        }

        private void GenerateSourceCode()
        {
            var nameSpace = ResolveNameSpace();

            UnsubscribeTablePresenters();
            Task.Factory.StartNew(() =>
            {
                var selectedTables = Tables.Where(t => t.Selected).Select(t => t.Table).ToArray();
                var csharp = CodeGeneration.generateCsharp(selectedTables, nameSpace);

                dispatcher.Invoke(() =>
                {
                    return SourceCode = csharp;
                });

                SubscribeTablePresenters();
                Document.Tables = Tables.Select(t => t.Table.Name).ToArray();
                Document.SelectedTables = selectedTables.Select(t => t.Name).ToArray();
                documentStorage.Save(Document, Filename);
            });
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
                        var presenter = new TableDescPresenter
                        {
                            Selected = false,
                            Table = tableDesc
                        };
                        Tables.Add(presenter);
                    }

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
            GenerateSourceCode();
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

    public class RelayCommand : ICommand
    {
        private readonly Action action;

        public RelayCommand(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action?.Invoke();
        }

        public event EventHandler CanExecuteChanged;
    }
}
