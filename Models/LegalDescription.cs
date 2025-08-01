using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LegalDescription")]
public class LegalDescription
{
    [XmlElement("Description")]
    public string Description { get; set; }

    [XmlElement("Description2")]
    public string Description2 { get; set; }

    [XmlElement("Description3")]
    public string Description3 { get; set; }

}