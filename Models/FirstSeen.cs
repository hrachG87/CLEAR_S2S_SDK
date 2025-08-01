using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FirstSeen")]
public class FirstSeen
{
    [XmlElement("Human")]
    public string Human { get; set; }

    [XmlElement("TimeStamp")]
    public string TimeStamp { get; set; }

    [XmlElement("ISO")]
    public string ISO { get; set; }

}