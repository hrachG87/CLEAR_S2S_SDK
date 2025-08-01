using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ServicesProvided")]
public class ServicesProvided
{
    [XmlElement("Service")]
    public List<string> Service { get; set; }
}
