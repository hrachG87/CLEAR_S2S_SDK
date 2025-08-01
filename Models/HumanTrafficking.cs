using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("HumanTrafficking")]
public class HumanTrafficking
{
    [XmlElement("HumanTraffickingFlag")]
    public RiskFlagInfo HumanTraffickingFlag { get; set; }
}
