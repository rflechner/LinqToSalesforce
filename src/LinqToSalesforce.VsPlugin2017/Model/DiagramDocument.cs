using System.Collections.Generic;
using System.Linq;
using LinqToSalesforce.VsPlugin2017.ViewModels;

namespace LinqToSalesforce.VsPlugin2017.Model
{
    public class DiagramDocument
    {

        public Credentials Credentials { get; set; }

        public KeyValuePair<string,string[]>[] Tables { get; set; }

        public Dictionary<string, string[]> GetTables() => Tables?.ToDictionary(kv => kv.Key, kv => kv.Value);

        public string[] SelectedTables { get; set; }
    }
}
