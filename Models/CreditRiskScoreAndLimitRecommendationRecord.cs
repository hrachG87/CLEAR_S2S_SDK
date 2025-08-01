using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CreditRiskScoreAndLimitRecommendationRecord")]
public class CreditRiskScoreAndLimitRecommendationRecord
{
    [XmlElement("IntelliscorePlusDetails")]
    public IntelliscorePlusDetails IntelliscorePlusDetails { get; set; }

    [XmlElement("FinancialStabilityRiskDetails")]
    public FinancialStabilityRiskDetails FinancialStabilityRiskDetails { get; set; }

    [XmlElement("QuarterlyScoreTrends")]
    public QuarterlyScoreTrends QuarterlyScoreTrends { get; set; }

    [XmlElement("CreditLimitRecommendation")]
    public int CreditLimitRecommendation { get; set; }

}