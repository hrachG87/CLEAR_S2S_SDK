using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryRobbery")]
public class CriminalCategoryRobbery
{
    [XmlElement("RobberyBusinessWithGun")]
    public CriminalChargetypes RobberyBusinessWithGun { get; set; }

    [XmlElement("RobberyBusinessWithWeapon")]
    public CriminalChargetypes RobberyBusinessWithWeapon { get; set; }

    [XmlElement("StrongArmRobberyOfBusiness")]
    public CriminalChargetypes StrongArmRobberyOfBusiness { get; set; }

    [XmlElement("RobberyOnStreetWithGun")]
    public CriminalChargetypes RobberyOnStreetWithGun { get; set; }

    [XmlElement("RobberyOnStreetWithWeapon")]
    public CriminalChargetypes RobberyOnStreetWithWeapon { get; set; }

    [XmlElement("StrongArmRobberyOnStreet")]
    public CriminalChargetypes StrongArmRobberyOnStreet { get; set; }

    [XmlElement("RobberyResidenceWithGun")]
    public CriminalChargetypes RobberyResidenceWithGun { get; set; }

    [XmlElement("RobberyResidenceWithWeapon")]
    public CriminalChargetypes RobberyResidenceWithWeapon { get; set; }

    [XmlElement("StrongArmRobberyResidence")]
    public CriminalChargetypes StrongArmRobberyResidence { get; set; }

    [XmlElement("ForciblePurseSnatching")]
    public CriminalChargetypes ForciblePurseSnatching { get; set; }

    [XmlElement("RobberyBank")]
    public CriminalChargetypes RobberyBank { get; set; }

    [XmlElement("ArmedCarjacking")]
    public CriminalChargetypes ArmedCarjacking { get; set; }

    [XmlElement("Robbery")]
    public CriminalChargetypes Robbery { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
