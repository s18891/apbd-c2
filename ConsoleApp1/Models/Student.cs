using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp1.Models
{
    public class Student
    {
        [XmlAttribute(AttributeName = "indexNumber")]
        
        public string numerstudenta { get; set; }

        
        [XmlElement(ElementName = "fname")]
        public string Imie { get; set; }

        [XmlElement(ElementName = "lname")]
        public string Nazwisko { get; set; }
        
        [XmlElement(ElementName = "birthdate")]
        public string dataUrodzenia { get; set; }
        
        [XmlElement(ElementName = "email")]
        public string email { get; set; }
        
        [XmlElement(ElementName = "mothersname")]
        public string imieMatki { get; set; }
        
        [XmlElement(ElementName = "fathersname")]
        public string imieOjca { get; set; }
     
        //[XmlElement(ElementName = "studies")] /// nie wiem jak zrobić nowy znacznik
        
        [XmlElement(ElementName = "name")]
        public string kierunekStudiow { get; set; }
        
        [XmlElement(ElementName = "mode")]
        public string typStudiow { get; set; }

    }
}
