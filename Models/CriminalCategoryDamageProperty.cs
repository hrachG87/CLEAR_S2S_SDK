using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategoryDamageProperty")]
public class CriminalCategoryDamageProperty
{
    [XmlElement("DamageBusinessPropertyExplosives")]
    public CriminalChargetypes DamageBusinessPropertyExplosives { get; set; }

    [XmlElement("DamagePrivatePropertyExplosives")]
    public CriminalChargetypes DamagePrivatePropertyExplosives { get; set; }

    [XmlElement("DamagePublicPropertyExplosives")]
    public CriminalChargetypes DamagePublicPropertyExplosives { get; set; }

    [XmlElement("DamageBusinessProperty")]
    public CriminalChargetypes DamageBusinessProperty { get; set; }

    [XmlElement("DamagePrivateProperty")]
    public CriminalChargetypes DamagePrivateProperty { get; set; }

    [XmlElement("DamagePublicProperty")]
    public CriminalChargetypes DamagePublicProperty { get; set; }

    [XmlElement("CriminalMischief")]
    public CriminalChargetypes CriminalMischief { get; set; }

    [XmlElement("DamageTamperMotorVehicle")]
    public CriminalChargetypes DamageTamperMotorVehicle { get; set; }

    [XmlElement("DamageToCemeteryBurialSite")]
    public CriminalChargetypes DamageToCemeteryBurialSite { get; set; }

    [XmlElement("DamageProperty")]
    public CriminalChargetypes DamageProperty { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}