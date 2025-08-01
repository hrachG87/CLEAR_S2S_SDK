using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalSubcategoryMurderNonNegligentManslaughter")]
public class CriminalSubcategoryMurderNonNegligentManslaughter
{
    [XmlElement("PremeditatedHomicideFamilyWithGun")]
    public CriminalChargetypes PremeditatedHomicideFamilyWithGun { get; set; }

    [XmlElement("PremeditatedHomicideFamilyWithWeapon")]
    public CriminalChargetypes PremeditatedHomicideFamilyWithWeapon { get; set; }

    [XmlElement("PremeditatedHomicideNonFamilyWithGun")]
    public CriminalChargetypes PremeditatedHomicideNonFamilyWithGun { get; set; }

    [XmlElement("PremeditatedHomicideNonFamilyWithWeapon")]
    public CriminalChargetypes PremeditatedHomicideNonFamilyWithWeapon { get; set; }

    [XmlElement("PremeditatedHomicidePublicOfficialWithGun")]
    public CriminalChargetypes PremeditatedHomicidePublicOfficialWithGun { get; set; }

    [XmlElement("PremeditatedHomicidePublicOfficialWithWeapon")]
    public CriminalChargetypes PremeditatedHomicidePublicOfficialWithWeapon { get; set; }

    [XmlElement("PremeditatedHomicidePoliceOfficerWithGun")]
    public CriminalChargetypes PremeditatedHomicidePoliceOfficerWithGun { get; set; }

    [XmlElement("PremeditatedHomicidePoliceOfficerWithWeapon")]
    public CriminalChargetypes PremeditatedHomicidePoliceOfficerWithWeapon { get; set; }

    [XmlElement("PremeditatedHomicideWithGun")]
    public CriminalChargetypes PremeditatedHomicideWithGun { get; set; }

    [XmlElement("PremeditatedHomicideWithWeapon")]
    public CriminalChargetypes PremeditatedHomicideWithWeapon { get; set; }

    [XmlElement("HomicideDoe")]
    public CriminalChargetypes HomicideDoe { get; set; }

    [XmlElement("HomicideDuringFelony")]
    public CriminalChargetypes HomicideDuringFelony { get; set; }

    [XmlElement("Homicide")]
    public CriminalChargetypes Homicide { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}