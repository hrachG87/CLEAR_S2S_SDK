using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("IntelliscorePlusDetails")]
public class IntelliscorePlusDetails
{
    [XmlElement("CurrentScore")]
    public int CurrentScore { get; set; }

    [XmlElement("IndustryRiskComparison")]
    public int IndustryRiskComparison { get; set; }

    [XmlElement("CreditRiskScoreDetails")]
    public CreditRiskScoreDetails CreditRiskScoreDetails { get; set; }
}
