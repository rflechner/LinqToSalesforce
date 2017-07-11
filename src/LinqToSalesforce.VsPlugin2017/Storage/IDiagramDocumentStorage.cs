using LinqToSalesforce.VsPlugin2017.Model;
using LinqToSalesforce.VsPlugin2017.Model.Documents;

namespace LinqToSalesforce.VsPlugin2017.Storage
{
    public interface IDiagramDocumentStorage
    {
        DiagramDocument LoadDocument(string filename);
        void Save(DiagramDocument document, string filename);
    }
}