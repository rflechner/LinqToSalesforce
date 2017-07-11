using EnvDTE;
using LinqToSalesforce.VsPlugin2017.Ioc;
using LinqToSalesforce.VsPlugin2017.Storage;

namespace LinqToSalesforce.VsPlugin2017.ViewModels
{
    public class MainViewModel
    {
        public TablesSelectViewModel TablesSelect { get; set; }

        public MainViewModel()
        {
            var services = IocServiceProvider.Current;
            TablesSelect = new TablesSelectViewModel(services.Dte, services.DiagramDocumentStorage, services.Filename, services.Identity);
        }
    }
}
