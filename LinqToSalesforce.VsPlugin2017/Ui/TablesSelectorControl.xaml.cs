using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using EnvDTE;
using LinqToSalesforce.VsPlugin2017.Model;
using LinqToSalesforce.VsPlugin2017.Storage;
using LinqToSalesforce.VsPlugin2017.ViewModels;

namespace LinqToSalesforce.VsPlugin2017.Ui
{
    /// <summary>
    /// Interaction logic for TablesSelectorControl.xaml
    /// </summary>
    public partial class TablesSelectorControl : UserControl
    {
        public EventHandler Backclicked;

        
        private readonly DTE dte;
        private readonly TablesSelectViewModel viewModel;

        public TablesSelectorControl(string filename, DiagramDocument document, Rest.OAuth.Identity identity, DTE dte)
        {
            this.dte = dte;
            
            viewModel = new TablesSelectViewModel(dte, Dispatcher, new DiagramDocumentStorage(), document, filename, identity);
            
            InitializeComponent();
        }
        

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            DataContext = viewModel;
            TablesListView.ItemsSource = viewModel.Tables;
            
            viewModel.LoadTables();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            Backclicked?.Invoke(this, new EventArgs());
        }
    }
}
