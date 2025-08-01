using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Racketeering")]
public class Racketeering
{
    [XmlElement("RacketeeringFlag")]
    public RiskFlagInfo RacketeeringFlag { get; set; }

    [XmlElement("ProceedsFromRacketeering")]
    public RiskFlagInfo ProceedsFromRacketeering { get; set; }

    [XmlElement("PropertyFromRacketeering")]
    public RiskFlagInfo PropertyFromRacketeering { get; set; }

    [XmlElement("ConspiracyRacketeering")]
    public RiskFlagInfo ConspiracyRacketeering { get; set; }
}
