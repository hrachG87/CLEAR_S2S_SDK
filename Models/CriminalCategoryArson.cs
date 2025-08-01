using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryArson")]
public class CriminalCategoryArson
{
    [XmlElement("ArsonBusinessEndangerLife")]
    public CriminalChargetypes ArsonBusinessEndangerLife { get; set; }

    [XmlElement("ArsonResidenceEndangerLife")]
    public CriminalChargetypes ArsonResidenceEndangerLife { get; set; }

    [XmlElement("ArsonBusinessdeFraudInsurer")]
    public CriminalChargetypes ArsonBusinessdeFraudInsurer { get; set; }

    [XmlElement("ArsonResidencedeFraudInsurer")]
    public CriminalChargetypes ArsonResidencedeFraudInsurer { get; set; }

    [XmlElement("ArsonOfBusiness")]
    public CriminalChargetypes ArsonOfBusiness { get; set; }

    [XmlElement("ArsonOfResidence")]
    public CriminalChargetypes ArsonOfResidence { get; set; }

    [XmlElement("BurningOffense")]
    public CriminalChargetypes BurningOffense { get; set; }

    [XmlElement("ArsonPublicBldgEndangeredlives")]
    public CriminalChargetypes ArsonPublicBldgEndangeredlives { get; set; }

    [XmlElement("ArsonOfPublicBuilding")]
    public CriminalChargetypes ArsonOfPublicBuilding { get; set; }

    [XmlElement("ArsonWillfulDamageToDwelling")]
    public CriminalChargetypes ArsonWillfulDamageToDwelling { get; set; }

    [XmlElement("ArsonWillfulDamageToStructure")]
    public CriminalChargetypes ArsonWillfulDamageToStructure { get; set; }

    [XmlElement("ArsonWillfulInjuryToPerson")]
    public CriminalChargetypes ArsonWillfulInjuryToPerson { get; set; }

    [XmlElement("ArsonToDefraudInsurer")]
    public CriminalChargetypes ArsonToDefraudInsurer { get; set; }

    [XmlElement("Arson")]
    public CriminalChargetypes Arson { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}
}