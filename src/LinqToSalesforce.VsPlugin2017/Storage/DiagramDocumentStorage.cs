using System.IO;
using System.Xml.Serialization;
using LinqToSalesforce.VsPlugin2017.Model;
using LinqToSalesforce.VsPlugin2017.Model.Documents;
using Newtonsoft.Json;

namespace LinqToSalesforce.VsPlugin2017.Storage
{
    public class DiagramDocumentStorage : IDiagramDocumentStorage
    {

        static readonly object locker = new object();

        public DiagramDocument LoadDocument(string filename)
        {
            lock (locker)
            {
                if (!File.Exists(filename))
                    return null;

                try
                {
                    var json = File.ReadAllText(filename);
                    return JsonConvert.DeserializeObject<DiagramDocument>(json);
                }
                catch
                {
                    return null;
                }
            }
        }

        public void Save(DiagramDocument document, string filename)
        {
            lock (locker)
            {
                var json = JsonConvert.SerializeObject(document);
                File.WriteAllText(filename, json);
            }
        }
    }
}
