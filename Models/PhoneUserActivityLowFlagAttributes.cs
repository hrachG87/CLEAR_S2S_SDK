using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PhoneUserActivityLowFlagAttributes")]
public class PhoneUserActivityLowFlagAttributes
{
    [XmlElement("TotalScoreLowered")]
    public double TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("Value")]
    public string Value { get; set; }

}