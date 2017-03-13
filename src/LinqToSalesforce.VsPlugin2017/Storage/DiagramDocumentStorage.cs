using System.IO;
using System.Xml.Serialization;
using LinqToSalesforce.VsPlugin2017.Model;

namespace LinqToSalesforce.VsPlugin2017.Storage
{
    public class DiagramDocumentStorage : IDiagramDocumentStorage
    {

        static readonly object locker = new object();

        readonly XmlSerializer serializer = new XmlSerializer(typeof(DiagramDocument));
        
        public DiagramDocument LoadDocument(string filename)
        {
            lock (locker)
            {
                if (!File.Exists(filename))
                    return null;

                try
                {
                    using (var stream = File.OpenRead(filename))
                        return (DiagramDocument) serializer.Deserialize(stream);
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
                using (var stream = File.Open(filename, FileMode.Create))
                {
                    serializer.Serialize(stream, document);
                    stream.Close();
                }
            }
        }
    }
}
