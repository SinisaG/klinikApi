using DBVC;
using Klinik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Klinik.Api
{
    [Serializable]
    public class Result : IResult
    {
        [XmlAttribute]
        public string errorMessage { get; set; }
        [XmlAttribute]
        public int status { get; set; }
        [XmlAttribute]
        public string dbMessage { get; set; }
        [XmlAttribute]
        public string procName { get; set; }
        [XmlElement]
        public Content Content { get; set; }
        [XmlElement]
        public List<Image> Images { get; set; }
        [XmlElement]
        public List<Text> Texts { get; set; }
        [XmlElement]
        public Text Text { get; set; }
    }
}
