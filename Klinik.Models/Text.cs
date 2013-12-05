using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Klinik.Models
{
    [Serializable]
    public class Text
    {
        [XmlAttribute]
        public int id { get; set; }
        [XmlAttribute]
        public string title { get; set; }
        [XmlAttribute]
        public string body { get; set; }
    }
}
