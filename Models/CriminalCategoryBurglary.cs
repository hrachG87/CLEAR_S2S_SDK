using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryBurglary")]
public class CriminalCategoryBurglary
{
    [XmlElement("BurglaryOfSafe")]
    public CriminalChargetypes BurglaryOfSafe { get; set; }

    [XmlElement("BurglaryByForceEntryResidence")]
    public CriminalChargetypes BurglaryByForceEntryResidence { get; set; }

    [XmlElement("BurglaryByForceEntryNonResidence")]
    public CriminalChargetypes BurglaryByForceEntryNonResidence { get; set; }

    [XmlElement("BurglaryResidenceWithoutForce")]
    public CriminalChargetypes BurglaryResidenceWithoutForce { get; set; }

    [XmlElement("BurglaryNonResidenceWithoutForce")]
    public CriminalChargetypes BurglaryNonResidenceWithoutForce { get; set; }

    [XmlElement("PossessionBurglaryTools")]
    public CriminalChargetypes PossessionBurglaryTools { get; set; }

    [XmlElement("BurglaryOfBank")]
    public CriminalChargetypes BurglaryOfBank { get; set; }

    [XmlElement("BurglaryAssaultOfPerson")]
    public CriminalChargetypes BurglaryAssaultOfPerson { get; set; }

    [XmlElement("ArmedBurglary")]
    public CriminalChargetypes ArmedBurglary { get; set; }

    [XmlElement("BurglaryOfStructureAssault")]
    public CriminalChargetypes BurglaryOfStructureAssault { get; set; }

    [XmlElement("BurglaryOfDwellingOrVehicle")]
    public CriminalChargetypes BurglaryOfDwellingOrVehicle { get; set; }

    [XmlElement("BurglaryStuctDamage1K")]
    public CriminalChargetypes BurglaryStuctDamage1K { get; set; }

    [XmlElement("TrespassStructArmed")]
    public CriminalChargetypes TrespassStructArmed { get; set; }

    [XmlElement("TrespassPropertyArmed")]
    public CriminalChargetypes TrespassPropertyArmed { get; set; }

    [XmlElement("BurglaryTrespassConstructSite")]
    public CriminalChargetypes BurglaryTrespassConstructSite { get; set; }

    [XmlElement("TrespassHorticultrProperty")]
    public CriminalChargetypes TrespassHorticultrProperty { get; set; }

    [XmlElement("HomeInvasionInjuryDeath")]
    public CriminalChargetypes HomeInvasionInjuryDeath { get; set; }

    [XmlElement("HomeInvasionComFelony")]
    public CriminalChargetypes HomeInvasionComFelony { get; set; }

    [XmlElement("TrespassSchoolWithWeapon")]
    public CriminalChargetypes TrespassSchoolWithWeapon { get; set; }

    [XmlElement("Burglary")]
    public CriminalChargetypes Burglary { get; set; }

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