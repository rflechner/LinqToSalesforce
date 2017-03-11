using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using LinqToSalesforce.VsPlugin2017.Model;

namespace LinqToSalesforce.VsPlugin2017.Storage
{
    public interface IDiagramDocumentStorage
    {
        DiagramDocument LoadDocument(string filename);
        void Save(DiagramDocument document, string filename);
    }

    public class DiagramDocumentStorage
    {
        readonly XmlSerializer serializer = new XmlSerializer(typeof(DiagramDocument));


        public DiagramDocument LoadDocument(string filename)
        {
            if (!File.Exists(filename))
                return null;

            try
            {
                using (var stream = File.OpenRead(filename))
                    return (DiagramDocument)serializer.Deserialize(stream);
            }
            catch
            {
                return null;
            }
        }

        public void Save(DiagramDocument document, string filename)
        {
            using (var stream = File.OpenWrite(filename))
                serializer.Serialize(stream, document);
        }
    }
}
