using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AKAPersonName")]
public class AKAPersonName
{
    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("MiddleName")]
    public string MiddleName { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }
}
