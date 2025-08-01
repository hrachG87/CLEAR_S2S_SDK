using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Scheduled341")]
public class Scheduled341
{
    [XmlElement("Scheduled341Date")]
    public string Scheduled341Date { get; set; }

    [XmlElement("Scheduled341Description")]
    public string Scheduled341Description { get; set; }

    [XmlElement("Scheduled341Location")]
    public string Scheduled341Location { get; set; }

    [XmlElement("Scheduled341Time")]
    public string Scheduled341Time { get; set; }
}
