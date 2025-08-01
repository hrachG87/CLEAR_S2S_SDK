using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryWeaponOffenses")]
public class CriminalCategoryWeaponOffenses
{
    [XmlElement("AlteringIdOnWeapon")]
    public CriminalChargetypes AlteringIdOnWeapon { get; set; }

    [XmlElement("CarryConcealedWeapon")]
    public CriminalChargetypes CarryConcealedWeapon { get; set; }

    [XmlElement("CarryingProhibitedWeapon")]
    public CriminalChargetypes CarryingProhibitedWeapon { get; set; }

    [XmlElement("TeachingUseOfExplosives")]
    public CriminalChargetypes TeachingUseOfExplosives { get; set; }

    [XmlElement("TransportExplosives")]
    public CriminalChargetypes TransportExplosives { get; set; }

    [XmlElement("UsingExplosives")]
    public CriminalChargetypes UsingExplosives { get; set; }

    [XmlElement("PossessionIncendiaryDevice")]
    public CriminalChargetypes PossessionIncendiaryDevice { get; set; }

    [XmlElement("UsingIncendiaryDevice")]
    public CriminalChargetypes UsingIncendiaryDevice { get; set; }

    [XmlElement("TeachingUseOfIncendiaryDevice")]
    public CriminalChargetypes TeachingUseOfIncendiaryDevice { get; set; }

    [XmlElement("LicensingRegisterWeapon")]
    public CriminalChargetypes LicensingRegisterWeapon { get; set; }

    [XmlElement("PossessionOfExplosives")]
    public CriminalChargetypes PossessionOfExplosives { get; set; }

    [XmlElement("PossessionOfWeapon")]
    public CriminalChargetypes PossessionOfWeapon { get; set; }

    [XmlElement("FiringWeaponRemarks")]
    public CriminalChargetypes FiringWeaponRemarks { get; set; }

    [XmlElement("SellingWeapon")]
    public CriminalChargetypes SellingWeapon { get; set; }

    [XmlElement("ThreatenBomb")]
    public CriminalChargetypes ThreatenBomb { get; set; }

    [XmlElement("ThreatenBurn")]
    public CriminalChargetypes ThreatenBurn { get; set; }

    [XmlElement("WeaponTrafficking")]
    public CriminalChargetypes WeaponTrafficking { get; set; }

    [XmlElement("DriveByShooting")]
    public CriminalChargetypes DriveByShooting { get; set; }

    [XmlElement("PossessionOfFirearmDuringFelony")]
    public CriminalChargetypes PossessionOfFirearmDuringFelony { get; set; }

    [XmlElement("ConcealedPistolPermitViolation")]
    public CriminalChargetypes ConcealedPistolPermitViolation { get; set; }

    [XmlElement("UseFirearmUnderInfluence")]
    public CriminalChargetypes UseFirearmUnderInfluence { get; set; }

    [XmlElement("WeaponOffense")]
    public CriminalChargetypes WeaponOffense { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
