using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskIndicators")]
public class RiskIndicators
{
    [XmlElement("criticalRiskSeverity")]
    public RiskSeverity criticalRiskSeverity { get; set; }

    [XmlElement("highRiskSeverity")]
    public RiskSeverity highRiskSeverity { get; set; }

    [XmlElement("elevatedRiskSeverity")]
    public RiskSeverity elevatedRiskSeverity { get; set; }

    [XmlElement("riskRelevantSeverity")]
    public RiskSeverity riskRelevantSeverity { get; set; }

}