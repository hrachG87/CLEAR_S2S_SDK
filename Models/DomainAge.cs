using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DomainAge")]
public class DomainAge
{
    [XmlElement("Human")]
    public string Human { get; set; }

    [XmlElement("TimeStamp")]
    public string TimeStamp { get; set; }

    [XmlElement("ISO")]
    public string ISO { get; set; }
}
