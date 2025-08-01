using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalSubcategoryAggravatedAssault")]
public class CriminalSubcategoryAggravatedAssault
{
    [XmlElement("AggAssaultFamilyWithGun")]
    public CriminalChargetypes AggAssaultFamilyWithGun { get; set; }

    [XmlElement("AggAssaultFamilyWithWeapon")]
    public CriminalChargetypes AggAssaultFamilyWithWeapon { get; set; }

    [XmlElement("StrongArmAggAssaultFamilyWithGun")]
    public CriminalChargetypes StrongArmAggAssaultFamilyWithGun { get; set; }

    [XmlElement("AggAssaultNonFamilyWithGun")]
    public CriminalChargetypes AggAssaultNonFamilyWithGun { get; set; }

    [XmlElement("AggAssaultNonFamilyWithWeapon")]
    public CriminalChargetypes AggAssaultNonFamilyWithWeapon { get; set; }

    [XmlElement("StrongArmAggAssaultNonFamily")]
    public CriminalChargetypes StrongArmAggAssaultNonFamily { get; set; }

    [XmlElement("AggAssaultPublicOfficialWithGun")]
    public CriminalChargetypes AggAssaultPublicOfficialWithGun { get; set; }

    [XmlElement("AggAssaultPublicOfficialWithWeapon")]
    public CriminalChargetypes AggAssaultPublicOfficialWithWeapon { get; set; }

    [XmlElement("StrongArmAggAssaultPublicOfficial")]
    public CriminalChargetypes StrongArmAggAssaultPublicOfficial { get; set; }

    [XmlElement("AggAssaultPoliceWithGun")]
    public CriminalChargetypes AggAssaultPoliceWithGun { get; set; }

    [XmlElement("AggAssaultPoliceWithWeapon")]
    public CriminalChargetypes AggAssaultPoliceWithWeapon { get; set; }

    [XmlElement("StrongArmAggAssaultPolice")]
    public CriminalChargetypes StrongArmAggAssaultPolice { get; set; }

    [XmlElement("AggAssaultWithGun")]
    public CriminalChargetypes AggAssaultWithGun { get; set; }

    [XmlElement("AggAssaultWithWeapon")]
    public CriminalChargetypes AggAssaultWithWeapon { get; set; }

    [XmlElement("AggAssaultWeaponNoIntentToKill")]
    public CriminalChargetypes AggAssaultWeaponNoIntentToKill { get; set; }

    [XmlElement("AggAssaultWithFelonyIntent")]
    public CriminalChargetypes AggAssaultWithFelonyIntent { get; set; }

    [XmlElement("AggAssaultWithInjuryIntent")]
    public CriminalChargetypes AggAssaultWithInjuryIntent { get; set; }

    [XmlElement("AggAssaultOnFirstResponder")]
    public CriminalChargetypes AggAssaultOnFirstResponder { get; set; }

    [XmlElement("AggAssaultVulnerableVictim")]
    public CriminalChargetypes AggAssaultVulnerableVictim { get; set; }

    [XmlElement("AggAssaultNoWeapon")]
    public CriminalChargetypes AggAssaultNoWeapon { get; set; }

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