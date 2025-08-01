using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CreditRiskScoreDetails")]
public class CreditRiskScoreDetails
{
    [XmlElement("RiskClass")]
    public int RiskClass { get; set; }

    [XmlElement("RiskClassAssessment")]
    public string RiskClassAssessment { get; set; }

    [XmlElement("FactorsLoweringScore")]
    public FactorsLoweringScore FactorsLoweringScore { get; set; }
}
