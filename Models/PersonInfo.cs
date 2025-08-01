using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonInfo")]
public class PersonInfo
{
    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("PersonAddress")]
    public CommonDataAddress PersonAddress { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("Biography")]
    public string Biography { get; set; }

    [XmlElement("SSNInfo")]
    public SSNInfo SSNInfo { get; set; }

}