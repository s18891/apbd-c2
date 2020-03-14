using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp1.Models
{
    public class Student
    {
        [XmlElement(ElementName = "InneNazwa2")]
        public string Imie { get; set; }

        [XmlAttribute(AttributeName = "InnaNazwa")]
        public string Nazwisko { get; set; }

        [XmlAttribute(AttributeName = "InnaNazwa3")]
        public string Email { get; set; }

    }
}