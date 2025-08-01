using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("TrafficOffense")]
public class TrafficOffense
{
    [XmlElement("FailureToMaintainLiabilityInsurance")]
    public RiskFlagInfo FailureToMaintainLiabilityInsurance { get; set; }

    [XmlElement("TrafficOffenseFlag")]
    public RiskFlagInfo TrafficOffenseFlag { get; set; }
}
