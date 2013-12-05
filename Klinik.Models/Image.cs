using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Klinik.Models
{
    [Serializable]
    public class Image
    {
        [XmlAttribute]
        public int id { get; set; }
        [XmlAttribute]
        public string url { get; set; }
    }
}
