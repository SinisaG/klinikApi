using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Klinik.Models
{
    [Serializable]
    public class Content
    {
        [XmlElement]
        public List<Static> Static { get; set; }
    }
}
