using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DövizAlSatDemo
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("Tarih_Date")]
    public class Tarih_Date
    {
        [XmlElement(ElementName = "Currency")]
        public List<Currency> Kurlistesi { get; set; }
    }
}
