using System.Collections.Generic;
using System.Linq;

namespace LinqToSalesforce.VsPlugin2017.Model.Documents
{
    public class DiagramDocument
    {
        public Credentials Credentials { get; set; }

        public TableDocument[] Tables { get; set; }
        
        public string[] SelectedTables { get; set; }
    }

    public class TableDocument
    {
        public TableDocument(string name, string[] fields)
        {
            Name = name;
            Fields = fields;
        }

        public string Name { get; }
        public string[] Fields { get; }
    }
}
