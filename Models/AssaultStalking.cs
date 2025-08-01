using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AssaultStalking")]
public class AssaultStalking
{
    [XmlElement("SimpleAssault")]
    public RiskFlagInfo SimpleAssault { get; set; }

    [XmlElement("Assault")]
    public RiskFlagInfo Assault { get; set; }

    [XmlElement("AggAssaultFamilyWithGun")]
    public RiskFlagInfo AggAssaultFamilyWithGun { get; set; }

    [XmlElement("AggAssaultFamilyWithWeapon")]
    public RiskFlagInfo AggAssaultFamilyWithWeapon { get; set; }

    [XmlElement("AggAssaultNonFamilyWithGun")]
    public RiskFlagInfo AggAssaultNonFamilyWithGun { get; set; }

    [XmlElement("AggAssaultNonFamilyWithWeapon")]
    public RiskFlagInfo AggAssaultNonFamilyWithWeapon { get; set; }

    [XmlElement("AggAssaultPoliceWithGun")]
    public RiskFlagInfo AggAssaultPoliceWithGun { get; set; }

    [XmlElement("AggAssaultPoliceWithWeapon")]
    public RiskFlagInfo AggAssaultPoliceWithWeapon { get; set; }

    [XmlElement("AggAssaultPublicOfficialWithGun")]
    public RiskFlagInfo AggAssaultPublicOfficialWithGun { get; set; }

    [XmlElement("AggAssaultPublicOfficialWithWeapon")]
    public RiskFlagInfo AggAssaultPublicOfficialWithWeapon { get; set; }

    [XmlElement("AggAssaultWithGun")]
    public RiskFlagInfo AggAssaultWithGun { get; set; }

    [XmlElement("AggAssaultWithWeapon")]
    public RiskFlagInfo AggAssaultWithWeapon { get; set; }

    [XmlElement("StrongArmAggAssaultFamilyWithGun")]
    public RiskFlagInfo StrongArmAggAssaultFamilyWithGun { get; set; }

    [XmlElement("StrongArmAggAssaultNonFamily")]
    public RiskFlagInfo StrongArmAggAssaultNonFamily { get; set; }

    [XmlElement("StrongArmAggAssaultPolice")]
    public RiskFlagInfo StrongArmAggAssaultPolice { get; set; }

    [XmlElement("StrongArmAggAssaultPublicOfficial")]
    public RiskFlagInfo StrongArmAggAssaultPublicOfficial { get; set; }

    [XmlElement("Intimidation")]
    public RiskFlagInfo Intimidation { get; set; }

    [XmlElement("AggAssaultWeaponNoIntentToKill")]
    public RiskFlagInfo AggAssaultWeaponNoIntentToKill { get; set; }

    [XmlElement("AggAssaultWithFelonyIntent")]
    public RiskFlagInfo AggAssaultWithFelonyIntent { get; set; }

    [XmlElement("AggAssaultWithInjuryIntent")]
    public RiskFlagInfo AggAssaultWithInjuryIntent { get; set; }

    [XmlElement("AggAssaultOnFirstResponder")]
    public RiskFlagInfo AggAssaultOnFirstResponder { get; set; }

    [XmlElement("AssaultByInmate")]
    public RiskFlagInfo AssaultByInmate { get; set; }

    [XmlElement("AggAssaultVulnerableVictim")]
    public RiskFlagInfo AggAssaultVulnerableVictim { get; set; }

    [XmlElement("BiasMotivatedAssault")]
    public RiskFlagInfo BiasMotivatedAssault { get; set; }

    [XmlElement("AggAssaultNoWeapon")]
    public RiskFlagInfo AggAssaultNoWeapon { get; set; }

    [XmlElement("AssaultWithMotorVehicle")]
    public RiskFlagInfo AssaultWithMotorVehicle { get; set; }
}
