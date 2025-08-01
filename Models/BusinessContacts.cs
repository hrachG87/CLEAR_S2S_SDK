using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessContacts")]
public class BusinessContacts
{
    [XmlElement("Name")]
    public string Name { get; set; }
}
