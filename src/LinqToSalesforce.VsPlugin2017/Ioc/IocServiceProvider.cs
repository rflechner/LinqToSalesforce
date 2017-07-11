using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;
using LinqToSalesforce.VsPlugin2017.Storage;

namespace LinqToSalesforce.VsPlugin2017.Ioc
{
    public class IocServiceProvider
    {
        private static IocServiceProvider current;

        public static IocServiceProvider Current => current ?? (current = new IocServiceProvider());

        public IDiagramDocumentStorage DiagramDocumentStorage => new DiagramDocumentStorage();

        public DTE Dte { get; set; }
        public string Filename { get; set; }
        public Rest.OAuth.Identity Identity { get; set; }
    }
}
