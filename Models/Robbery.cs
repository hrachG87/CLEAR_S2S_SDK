using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Robbery")]
public class Robbery
{
    [XmlElement("RobberyBusinessWithGun")]
    public RiskFlagInfo RobberyBusinessWithGun { get; set; }

    [XmlElement("RobberyBusinessWithWeapon")]
    public RiskFlagInfo RobberyBusinessWithWeapon { get; set; }

    [XmlElement("StrongArmRobberyOfBusiness")]
    public RiskFlagInfo StrongArmRobberyOfBusiness { get; set; }

    [XmlElement("RobberyOnStreetWithGun")]
    public RiskFlagInfo RobberyOnStreetWithGun { get; set; }

    [XmlElement("RobberyOnStreetWithWeapon")]
    public RiskFlagInfo RobberyOnStreetWithWeapon { get; set; }

    [XmlElement("StrongArmRobberyOnStreet")]
    public RiskFlagInfo StrongArmRobberyOnStreet { get; set; }

    [XmlElement("RobberyResidenceWithGun")]
    public RiskFlagInfo RobberyResidenceWithGun { get; set; }

    [XmlElement("RobberyResidenceWithWeapon")]
    public RiskFlagInfo RobberyResidenceWithWeapon { get; set; }

    [XmlElement("StrongArmRobberyResidence")]
    public RiskFlagInfo StrongArmRobberyResidence { get; set; }

    [XmlElement("ForciblePurseSnatching")]
    public RiskFlagInfo ForciblePurseSnatching { get; set; }

    [XmlElement("RobberyBank")]
    public RiskFlagInfo RobberyBank { get; set; }

    [XmlElement("ArmedCarjacking")]
    public RiskFlagInfo ArmedCarjacking { get; set; }

    [XmlElement("RobberyFlag")]
    public RiskFlagInfo RobberyFlag { get; set; }

}
}