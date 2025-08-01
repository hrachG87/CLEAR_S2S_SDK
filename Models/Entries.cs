using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Entries")]
public class Entries
{
    [XmlElement("Amount")]
    public string Amount { get; set; }

    [XmlElement("Description")]
    public string Description { get; set; }
}
