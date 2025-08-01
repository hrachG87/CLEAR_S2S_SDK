using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DisposableEmailFlagAttributes")]
public class DisposableEmailFlagAttributes
{
    [XmlElement("TotalScoreLowered")]
    public double TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("Value")]
    public string Value { get; set; }

}