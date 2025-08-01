using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DamageProperty")]
public class DamageProperty
{
    [XmlElement("DamageBusinessPropertyExplosives")]
    public RiskFlagInfo DamageBusinessPropertyExplosives { get; set; }

    [XmlElement("DamagePrivatePropertyExplosives")]
    public RiskFlagInfo DamagePrivatePropertyExplosives { get; set; }

    [XmlElement("DamagePublicPropertyExplosives")]
    public RiskFlagInfo DamagePublicPropertyExplosives { get; set; }

    [XmlElement("DamageBusinessProperty")]
    public RiskFlagInfo DamageBusinessProperty { get; set; }

    [XmlElement("DamagePrivateProperty")]
    public RiskFlagInfo DamagePrivateProperty { get; set; }

    [XmlElement("DamagePublicProperty")]
    public RiskFlagInfo DamagePublicProperty { get; set; }

    [XmlElement("CriminalMischief")]
    public RiskFlagInfo CriminalMischief { get; set; }

    [XmlElement("DamageTamperMotorVehicle")]
    public RiskFlagInfo DamageTamperMotorVehicle { get; set; }

    [XmlElement("DamagePropertyFlag")]
    public RiskFlagInfo DamagePropertyFlag { get; set; }

    [XmlElement("CriminalMischiefComputerAccess")]
    public RiskFlagInfo CriminalMischiefComputerAccess { get; set; }

    [XmlElement("DamageToCemeteryBurialSite")]
    public RiskFlagInfo DamageToCemeteryBurialSite { get; set; }

    [XmlElement("DamageComputerIntroduceContaminant")]
    public RiskFlagInfo DamageComputerIntroduceContaminant { get; set; }
}
