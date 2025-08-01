using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Arson")]
public class Arson
{
    [XmlElement("ArsonBusinessEndangerLife")]
    public RiskFlagInfo ArsonBusinessEndangerLife { get; set; }

    [XmlElement("ArsonResidenceEndangerLife")]
    public RiskFlagInfo ArsonResidenceEndangerLife { get; set; }

    [XmlElement("ArsonBusinessdeFraudInsurer")]
    public RiskFlagInfo ArsonBusinessdeFraudInsurer { get; set; }

    [XmlElement("ArsonResidencedeFraudInsurer")]
    public RiskFlagInfo ArsonResidencedeFraudInsurer { get; set; }

    [XmlElement("ArsonOfBusiness")]
    public RiskFlagInfo ArsonOfBusiness { get; set; }

    [XmlElement("ArsonOfResidence")]
    public RiskFlagInfo ArsonOfResidence { get; set; }

    [XmlElement("BurningOffense")]
    public RiskFlagInfo BurningOffense { get; set; }

    [XmlElement("ArsonPublicBldgEndangeredLives")]
    public RiskFlagInfo ArsonPublicBldgEndangeredLives { get; set; }

    [XmlElement("ArsonOfPublicBuilding")]
    public RiskFlagInfo ArsonOfPublicBuilding { get; set; }

    [XmlElement("ArsonFlag")]
    public RiskFlagInfo ArsonFlag { get; set; }

    [XmlElement("ArsonWillfulDamageToDwelling")]
    public RiskFlagInfo ArsonWillfulDamageToDwelling { get; set; }

    [XmlElement("ArsonWillfulDamageToStructure")]
    public RiskFlagInfo ArsonWillfulDamageToStructure { get; set; }

    [XmlElement("ArsonWillfulInjuryToPerson")]
    public RiskFlagInfo ArsonWillfulInjuryToPerson { get; set; }

    [XmlElement("ArsonToDefraudInsurer")]
    public RiskFlagInfo ArsonToDefraudInsurer { get; set; }

}