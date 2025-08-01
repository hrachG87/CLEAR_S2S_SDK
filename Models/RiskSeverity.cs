using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskSeverity")]
public class RiskSeverity
{
    [XmlElement("riskIndicator")]
    public List<RiskIndicator> riskIndicator { get; set; }
}
