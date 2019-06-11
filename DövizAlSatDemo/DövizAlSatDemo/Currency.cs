using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DövizAlSatDemo
{
    [XmlRoot(ElementName = "Currency")]
    public class Currency
    {
        [System.Xml.Serialization.XmlElement("Isim")]
        public string Isim { get; set; }

        [System.Xml.Serialization.XmlElement("BanknoteBuying")]
        public string BanknoteBuying { get; set; }

        [System.Xml.Serialization.XmlElement("BanknoteSelling")]
        public string BanknoteSelling { get; set; }

    }
}
