using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Marijuana")]
public class Marijuana
{
    [XmlElement("MarijuanaSell")]
    public RiskFlagInfo MarijuanaSell { get; set; }

    [XmlElement("MarijuanaSmuggle")]
    public RiskFlagInfo MarijuanaSmuggle { get; set; }

    [XmlElement("MarijuanaProduce")]
    public RiskFlagInfo MarijuanaProduce { get; set; }

    [XmlElement("MarijuanaPossession")]
    public RiskFlagInfo MarijuanaPossession { get; set; }

    [XmlElement("MarijuanaRemarks")]
    public RiskFlagInfo MarijuanaRemarks { get; set; }
}
