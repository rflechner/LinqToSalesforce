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
using LinqToSalesforce.VsPlugin2017.Model;
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
        private readonly string filename;

        public TablesSelectorControl(string filename, DiagramDocument document, Rest.OAuth.Identity identity)
        {
            this.document = document;
            this.identity = identity;
            this.filename = filename;

            InitializeComponent();

            TablesListView.DataContext = this;
            TablesListView.DisplayMemberPath = "Name";
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            Task.Factory.StartNew(async () =>
            {
                Tables = new ObservableCollection<Rest.TableDesc>((await GetTableListAsync()).ToList());

                Dispatcher.Invoke(() => TablesListView.ItemsSource = Tables);
            });
        }

        private async Task<IEnumerable<Rest.TableDesc>> GetTableListAsync()
        {
            Action<string> logger = s =>
            {
                Console.WriteLine(s);
            };
            
            Rest.Config.ProductionInstance = document.Credentials.Instance;

            return FSharpAsync.RunSynchronously(Rest.getObjectsList(identity, logger), FSharpOption<int>.None,
                FSharpOption<CancellationToken>.None);
        }

        public ObservableCollection<Rest.TableDesc> Tables { get; set; }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            Backclicked?.Invoke(this, new EventArgs());
        }
    }
}
