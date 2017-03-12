using LinqToSalesforce.VsPlugin2017.ViewModels;

namespace LinqToSalesforce.VsPlugin2017.Model
{
    public class DiagramDocument
    {

        public Credentials Credentials { get; set; }
        public string[] Tables { get; set; }
        public string[] SelectedTables { get; set; }
    }
}
