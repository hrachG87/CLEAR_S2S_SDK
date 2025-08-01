using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("HomicideMurderManslaughter")]
public class HomicideMurderManslaughter
{
    [XmlElement("PremeditatedHomicideFamilyWithGun")]
    public RiskFlagInfo PremeditatedHomicideFamilyWithGun { get; set; }

    [XmlElement("PremeditatedHomicideFamilyWithWeapon")]
    public RiskFlagInfo PremeditatedHomicideFamilyWithWeapon { get; set; }

    [XmlElement("PremeditatedHomicideNonFamilyWithGun")]
    public RiskFlagInfo PremeditatedHomicideNonFamilyWithGun { get; set; }

    [XmlElement("PremeditatedHomicideNonFamilyWithWeapon")]
    public RiskFlagInfo PremeditatedHomicideNonFamilyWithWeapon { get; set; }

    [XmlElement("PremeditatedHomicidePublicOfficialWithGun")]
    public RiskFlagInfo PremeditatedHomicidePublicOfficialWithGun { get; set; }

    [XmlElement("PremeditatedHomicidePublicOfficialWithWeapon")]
    public RiskFlagInfo PremeditatedHomicidePublicOfficialWithWeapon { get; set; }

    [XmlElement("PremeditatedHomicidePoliceOfficerWithGun")]
    public RiskFlagInfo PremeditatedHomicidePoliceOfficerWithGun { get; set; }

    [XmlElement("PremeditatedHomicidePoliceOfficerWithWeapon")]
    public RiskFlagInfo PremeditatedHomicidePoliceOfficerWithWeapon { get; set; }

    [XmlElement("PremeditatedHomicideWithGun")]
    public RiskFlagInfo PremeditatedHomicideWithGun { get; set; }

    [XmlElement("PremeditatedHomicideWithWeapon")]
    public RiskFlagInfo PremeditatedHomicideWithWeapon { get; set; }

    [XmlElement("HomicideDoe")]
    public RiskFlagInfo HomicideDoe { get; set; }

    [XmlElement("HomicideDuringFelony")]
    public RiskFlagInfo HomicideDuringFelony { get; set; }

    [XmlElement("Homicide")]
    public RiskFlagInfo Homicide { get; set; }

    [XmlElement("NegligentManslaughterWithVehicle")]
    public RiskFlagInfo NegligentManslaughterWithVehicle { get; set; }

    [XmlElement("NegligentManslaughterWIthWeapon")]
    public RiskFlagInfo NegligentManslaughterWIthWeapon { get; set; }

    [XmlElement("HomicideAssisstingSuicide")]
    public RiskFlagInfo HomicideAssisstingSuicide { get; set; }
}
