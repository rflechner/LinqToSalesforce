using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EnvDTE;
using LinqToSalesforce.VsPlugin2017.Model;
using LinqToSalesforce.VsPlugin2017.Storage;
using LinqToSalesforce.VsPlugin2017.ViewModels;
using Microsoft.FSharp.Collections;
using Microsoft.FSharp.Control;
using Microsoft.FSharp.Core;
using Microsoft.VisualStudio.Text;

namespace LinqToSalesforce.VsPlugin2017.Ui
{
    /// <summary>
    /// Interaction logic for TablesSelectorControl.xaml
    /// </summary>
    public partial class TablesSelectorControl : UserControl
    {
        public EventHandler Backclicked;

        private readonly DiagramDocument document;
        private readonly Rest.OAuth.Identity identity;
        private readonly DTE dte;
        private readonly string filename;
        private readonly TablesSelectViewModel viewModel;

        public TablesSelectorControl(string filename, DiagramDocument document, Rest.OAuth.Identity identity, DTE dte)
        {
            this.document = document;
            this.identity = identity;
            this.dte = dte;
            this.filename = filename;
            
            viewModel = new TablesSelectViewModel(Dispatcher, new DiagramDocumentStorage(), ResolveNameSpace, document, filename, identity);
            
            InitializeComponent();
        }

        public string ResolveNameSpace()
        {
            var activeSolutionProjects = (Array)dte.ActiveSolutionProjects;
            if (activeSolutionProjects.Length <= 0)
                return "LinqToSalesforce";

            var dteProject = (Project)activeSolutionProjects.GetValue(0);
            var defaultNamespace = dteProject.Properties.Item("DefaultNamespace").Value;

            return defaultNamespace.ToString();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            DataContext = viewModel;
            //TablesListView.DisplayMemberPath = "Name";
            TablesListView.ItemsSource = viewModel.Tables;

            //Task.Factory.StartNew(async () =>
            //{
            //    Tables = new ObservableCollection<Rest.TableDesc>((await GetTableListAsync()).ToList());

            //    Dispatcher.Invoke(() => TablesListView.ItemsSource = Tables);
            //});

            viewModel.LoadTables();
        }

        //private async Task<IEnumerable<Rest.TableDesc>> GetTableListAsync()
        //{
        //    Action<string> logger = s =>
        //    {
        //        Console.WriteLine(s);
        //    };
            
        //    Rest.Config.ProductionInstance = document.Credentials.Instance;

        //    return FSharpAsync.RunSynchronously(Rest.getObjectsList(identity, logger), FSharpOption<int>.None,
        //        FSharpOption<CancellationToken>.None);
        //}

        //public ObservableCollection<Rest.TableDesc> Tables { get; set; }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            Backclicked?.Invoke(this, new EventArgs());
        }
    }
}
