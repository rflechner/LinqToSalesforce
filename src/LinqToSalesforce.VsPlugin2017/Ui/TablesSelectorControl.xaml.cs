using System;
using LinqToSalesforce.VsPlugin2017.ViewModels;

namespace LinqToSalesforce.VsPlugin2017.Ui
{
    /// <summary>
    /// Interaction logic for TablesSelectorControl.xaml
    /// </summary>
    public partial class TablesSelectorControl
    {
        public TablesSelectorControl()
        {
            InitializeComponent();
        }
        
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);


            // TODO: move this in XAML
            var viewmodel = DataContext as TablesSelectViewModel;
            if (viewmodel != null)
            {
                Browser.Navigate(new Uri(viewmodel.TutorialUrl));
            }
        }
    }
}
