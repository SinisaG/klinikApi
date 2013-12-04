using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Klinik.Models
{
    [Serializable]
    public class Static
    {
        [XmlAttribute]
        public string key { get; set; }
        [XmlAttribute]
        public string value { get; set; }
    }
}
