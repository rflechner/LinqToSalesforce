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

        private readonly TablesSelectViewModel viewModel;

        public TablesSelectorControl(string filename, DiagramDocument document, Rest.OAuth.Identity identity, DTE dte)
        {
            viewModel = new TablesSelectViewModel(dte, Dispatcher, new DiagramDocumentStorage(), document, filename, identity);
            
            InitializeComponent();
        }
        
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            DataContext = viewModel;
            TablesListView.ItemsSource = viewModel.Tables;
            
            viewModel.LoadTables();

            Browser.Navigate(new Uri("https://rflechner.github.io/LinqToSalesforce/tutorial.html"));
        }
        
        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            Backclicked?.Invoke(this, new EventArgs());
        }

        private void CodeButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ViewCode();
        }
    }
}
