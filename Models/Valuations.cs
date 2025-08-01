using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Valuations")]
public class Valuations
{
    [XmlElement("ImprovementValue")]
    public string ImprovementValue { get; set; }

    [XmlElement("LandValue")]
    public string LandValue { get; set; }

    [XmlElement("TotalValue")]
    public string TotalValue { get; set; }
}
