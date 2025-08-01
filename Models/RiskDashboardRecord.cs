using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskDashboardRecord")]
public class RiskDashboardRecord
{
    [XmlElement("IntelliscorePlusScore")]
    public int IntelliscorePlusScore { get; set; }

    [XmlElement("IntelliscorePlusLevel")]
    public string IntelliscorePlusLevel { get; set; }

    [XmlElement("FinancialStabilityRiskScore")]
    public int FinancialStabilityRiskScore { get; set; }

    [XmlElement("FinancialStabilityRiskLevel")]
    public string FinancialStabilityRiskLevel { get; set; }

    [XmlElement("CompanyDBT")]
    public int CompanyDBT { get; set; }

    [XmlElement("IndustryDBT")]
    public int IndustryDBT { get; set; }

    [XmlElement("OriginalFilings")]
    public int OriginalFilings { get; set; }

    [XmlElement("HighRiskAlerts")]
    public int HighRiskAlerts { get; set; }

    [XmlElement("CreditLimitRecommendation")]
    public int CreditLimitRecommendation { get; set; }
}
