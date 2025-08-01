using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DisturbingThePeace")]
public class DisturbingThePeace
{
    [XmlElement("DisturbPeace")]
    public RiskFlagInfo DisturbPeace { get; set; }

}