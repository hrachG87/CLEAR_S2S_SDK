using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WeaponOffenses")]
public class WeaponOffenses
{
    [XmlElement("AlteringIdOnWeapon")]
    public RiskFlagInfo AlteringIdOnWeapon { get; set; }

    [XmlElement("CarryConcealedWeapon")]
    public RiskFlagInfo CarryConcealedWeapon { get; set; }

    [XmlElement("CarryingProhibitedWeapon")]
    public RiskFlagInfo CarryingProhibitedWeapon { get; set; }

    [XmlElement("TeachingUseOfExplosives")]
    public RiskFlagInfo TeachingUseOfExplosives { get; set; }

    [XmlElement("TransportExplosives")]
    public RiskFlagInfo TransportExplosives { get; set; }

    [XmlElement("UsingExplosives")]
    public RiskFlagInfo UsingExplosives { get; set; }

    [XmlElement("PossessionIncendiaryDevice")]
    public RiskFlagInfo PossessionIncendiaryDevice { get; set; }

    [XmlElement("UsingIncendiaryDevice")]
    public RiskFlagInfo UsingIncendiaryDevice { get; set; }

    [XmlElement("TeachingUseOFIncendiaryDevice")]
    public RiskFlagInfo TeachingUseOFIncendiaryDevice { get; set; }

    [XmlElement("LicensingRegisterWeapon")]
    public RiskFlagInfo LicensingRegisterWeapon { get; set; }

    [XmlElement("PossessionOfExplosives")]
    public RiskFlagInfo PossessionOfExplosives { get; set; }

    [XmlElement("PossessionOfWeapon")]
    public RiskFlagInfo PossessionOfWeapon { get; set; }

    [XmlElement("FiringWeaponRemarks")]
    public RiskFlagInfo FiringWeaponRemarks { get; set; }

    [XmlElement("SellingWeapon")]
    public RiskFlagInfo SellingWeapon { get; set; }

    [XmlElement("ThreatenBomb")]
    public RiskFlagInfo ThreatenBomb { get; set; }

    [XmlElement("ThreatenBurn")]
    public RiskFlagInfo ThreatenBurn { get; set; }

    [XmlElement("WeaponTrafficking")]
    public RiskFlagInfo WeaponTrafficking { get; set; }

    [XmlElement("ConcealedPistolPermitViolation")]
    public RiskFlagInfo ConcealedPistolPermitViolation { get; set; }

    [XmlElement("UseFirearmUnderInfluence")]
    public RiskFlagInfo UseFirearmUnderInfluence { get; set; }

    [XmlElement("WeaponOffense")]
    public RiskFlagInfo WeaponOffense { get; set; }

    [XmlElement("DriveByShooting")]
    public RiskFlagInfo DriveByShooting { get; set; }

    [XmlElement("PossessionOfFirearmDuringFelony")]
    public RiskFlagInfo PossessionOfFirearmDuringFelony { get; set; }

}