using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Burglary")]
public class Burglary
{
    [XmlElement("BurglaryOfSafe")]
    public RiskFlagInfo BurglaryOfSafe { get; set; }

    [XmlElement("BurglaryByForceEntryResidence")]
    public RiskFlagInfo BurglaryByForceEntryResidence { get; set; }

    [XmlElement("BurglaryByForceEntryNonResidence")]
    public RiskFlagInfo BurglaryByForceEntryNonResidence { get; set; }

    [XmlElement("BurglaryResidenceWithoutForce")]
    public RiskFlagInfo BurglaryResidenceWithoutForce { get; set; }

    [XmlElement("BurglaryNonResidenceWithoutForce")]
    public RiskFlagInfo BurglaryNonResidenceWithoutForce { get; set; }

    [XmlElement("PossessionBurglaryTools")]
    public RiskFlagInfo PossessionBurglaryTools { get; set; }

    [XmlElement("BurglaryOfBank")]
    public RiskFlagInfo BurglaryOfBank { get; set; }

    [XmlElement("BurglaryAssaultOfPerson")]
    public RiskFlagInfo BurglaryAssaultOfPerson { get; set; }

    [XmlElement("ArmedBurglary")]
    public RiskFlagInfo ArmedBurglary { get; set; }

    [XmlElement("BurglaryOfStructureAssault")]
    public RiskFlagInfo BurglaryOfStructureAssault { get; set; }

    [XmlElement("BurglaryOfDwellingOrVehicle")]
    public RiskFlagInfo BurglaryOfDwellingOrVehicle { get; set; }

    [XmlElement("BurglaryStructDamage1k")]
    public RiskFlagInfo BurglaryStructDamage1k { get; set; }

    [XmlElement("TrespassStructArmed")]
    public RiskFlagInfo TrespassStructArmed { get; set; }

    [XmlElement("TrepassPropertyArmed")]
    public RiskFlagInfo TrepassPropertyArmed { get; set; }

    [XmlElement("BurglaryTrespassConstructSite")]
    public RiskFlagInfo BurglaryTrespassConstructSite { get; set; }

    [XmlElement("TrespassHorticultrProperty")]
    public RiskFlagInfo TrespassHorticultrProperty { get; set; }

    [XmlElement("HomeInvasionInjuryDeath")]
    public RiskFlagInfo HomeInvasionInjuryDeath { get; set; }

    [XmlElement("HomeInvasionComFelony")]
    public RiskFlagInfo HomeInvasionComFelony { get; set; }

    [XmlElement("TrespassSchoolWithWeapon")]
    public RiskFlagInfo TrespassSchoolWithWeapon { get; set; }

    [XmlElement("BurglaryFlag")]
    public RiskFlagInfo BurglaryFlag { get; set; }

}
}