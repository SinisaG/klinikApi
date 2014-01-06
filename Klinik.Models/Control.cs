using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Klinik.Models
{
    [Serializable]
    public class Control
    {
        [XmlAttribute]
        public string name { get; set; }
        [XmlAttribute]
        public bool value { get; set; }
    }
}
