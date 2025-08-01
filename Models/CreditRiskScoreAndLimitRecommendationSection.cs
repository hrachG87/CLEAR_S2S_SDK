using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CreditRiskScoreAndLimitRecommendationSection")]
public class CreditRiskScoreAndLimitRecommendationSection
{
    [XmlElement("CreditRiskScoreAndLimitRecommendationRecord")]
    public List<CreditRiskScoreAndLimitRecommendationRecord> CreditRiskScoreAndLimitRecommendationRecord { get; set; }

}