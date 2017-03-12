using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
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
        private readonly Dispatcher dispatcher;
        private readonly IDiagramDocumentStorage documentStorage;
        private readonly Func<string> resolveNameSpace;
        private bool allChecked;
        private string sourceCode;

        public TablesSelectViewModel(Dispatcher dispatcher, IDiagramDocumentStorage documentStorage,
            Func<string> resolveNameSpace,
            DiagramDocument document, string filename, Rest.OAuth.Identity identity)
        {
            this.dispatcher = dispatcher;
            this.documentStorage = documentStorage;
            this.resolveNameSpace = resolveNameSpace;
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
            var nameSpace = resolveNameSpace();

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
}
