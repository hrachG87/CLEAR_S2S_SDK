using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Contact")]
public class Contact
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }
}
