using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Conspiracy")]
public class Conspiracy
{
    [XmlElement("ConspiracyFlag")]
    public RiskFlagInfo ConspiracyFlag { get; set; }

}