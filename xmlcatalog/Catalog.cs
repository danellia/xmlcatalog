using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace xmlcatalog
{
    [Serializable]
    [XmlRoot("CATALOG")]
    public class Catalog
    {
        [XmlElement("CD")]
        public List<CD> CD { get; set; } 
    }

    [Serializable]
    public class CD
    {
        [XmlElement("TITLE")]
        public string title { get; set; }
        [XmlElement("ARTIST")]
        public string artist { get; set; }
        [XmlElement("COUNTRY")]
        public string country { get; set; }
        [XmlElement("COMPANY")]
        public string company { get; set; }
        [XmlElement("PRICE")]
        public double price { get; set; }
        [XmlElement("YEAR")]
        public int year { get; set; }
    }

    public class Serializer
    {
        public Catalog deserialize(string path)
        {
            Catalog catalog;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Catalog), new XmlRootAttribute("CATALOG"));
            using (StreamReader reader = new StreamReader(path))
            {
                catalog = (Catalog)xmlSerializer.Deserialize(reader);
            }
            return catalog;
        }
    }
}

