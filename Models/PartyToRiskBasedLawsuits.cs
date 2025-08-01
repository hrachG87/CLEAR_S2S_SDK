using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PartyToRiskBasedLawsuits")]
public class PartyToRiskBasedLawsuits
{
    [XmlElement("AntitrustAgainstBusiness")]
    public BusinessRiskFlagInfo AntitrustAgainstBusiness { get; set; }

    [XmlElement("ConsumerProtection")]
    public BusinessRiskFlagInfo ConsumerProtection { get; set; }

    [XmlElement("Asbestos")]
    public BusinessRiskFlagInfo Asbestos { get; set; }

    [XmlElement("AgeDiscrimination")]
    public BusinessRiskFlagInfo AgeDiscrimination { get; set; }

    [XmlElement("RacialDiscrimination")]
    public BusinessRiskFlagInfo RacialDiscrimination { get; set; }

    [XmlElement("SexDiscrimination")]
    public BusinessRiskFlagInfo SexDiscrimination { get; set; }

    [XmlElement("ClassAction")]
    public BusinessRiskFlagInfo ClassAction { get; set; }

    [XmlElement("ConstructionDefect")]
    public BusinessRiskFlagInfo ConstructionDefect { get; set; }

    [XmlElement("Environmental")]
    public BusinessRiskFlagInfo Environmental { get; set; }

    [XmlElement("ForfeiturePenalty")]
    public BusinessRiskFlagInfo ForfeiturePenalty { get; set; }

    [XmlElement("SexualHarassment")]
    public BusinessRiskFlagInfo SexualHarassment { get; set; }

    [XmlElement("WorkplaceViolence")]
    public BusinessRiskFlagInfo WorkplaceViolence { get; set; }

    [XmlElement("Malpractice")]
    public BusinessRiskFlagInfo Malpractice { get; set; }

    [XmlElement("ProductLiability")]
    public BusinessRiskFlagInfo ProductLiability { get; set; }

    [XmlElement("DramShop")]
    public BusinessRiskFlagInfo DramShop { get; set; }

    [XmlElement("RICO")]
    public BusinessRiskFlagInfo RICO { get; set; }

    [XmlElement("WrongfulDeath")]
    public BusinessRiskFlagInfo WrongfulDeath { get; set; }
}
