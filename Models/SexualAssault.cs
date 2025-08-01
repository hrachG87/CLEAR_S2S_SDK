using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SexualAssault")]
public class SexualAssault
{
    [XmlElement("RapeWithGun")]
    public RiskFlagInfo RapeWithGun { get; set; }

    [XmlElement("RapeWithWeapon")]
    public RiskFlagInfo RapeWithWeapon { get; set; }

    [XmlElement("StrongArmRape")]
    public RiskFlagInfo StrongArmRape { get; set; }

    [XmlElement("SexAssaultSodomyBoyWithGun")]
    public RiskFlagInfo SexAssaultSodomyBoyWithGun { get; set; }

    [XmlElement("SexAssaultSodomyManWithGun")]
    public RiskFlagInfo SexAssaultSodomyManWithGun { get; set; }

    [XmlElement("SexAssaultSodomyGirlWithGun")]
    public RiskFlagInfo SexAssaultSodomyGirlWithGun { get; set; }

    [XmlElement("SexAssaultSodomyWomanWithGun")]
    public RiskFlagInfo SexAssaultSodomyWomanWithGun { get; set; }

    [XmlElement("SexAssaultSodomyBoyWithWeapon")]
    public RiskFlagInfo SexAssaultSodomyBoyWithWeapon { get; set; }

    [XmlElement("SexAssaultSodomyManWithWeapon")]
    public RiskFlagInfo SexAssaultSodomyManWithWeapon { get; set; }

    [XmlElement("SexAssaultSodomyGirlWithWeapon")]
    public RiskFlagInfo SexAssaultSodomyGirlWithWeapon { get; set; }

    [XmlElement("SexAssaultSodomyWomanWithWeapon")]
    public RiskFlagInfo SexAssaultSodomyWomanWithWeapon { get; set; }

    [XmlElement("StrongArmSexAssaultSodomyBoy")]
    public RiskFlagInfo StrongArmSexAssaultSodomyBoy { get; set; }

    [XmlElement("StrongArmSexAssaultSodomyMan")]
    public RiskFlagInfo StrongArmSexAssaultSodomyMan { get; set; }

    [XmlElement("StrongArmSexAssaultSodomyGirl")]
    public RiskFlagInfo StrongArmSexAssaultSodomyGirl { get; set; }

    [XmlElement("StrongArmSexAssaultSodomyWoman")]
    public RiskFlagInfo StrongArmSexAssaultSodomyWoman { get; set; }

    [XmlElement("StatutoryRapeWithoutForce")]
    public RiskFlagInfo StatutoryRapeWithoutForce { get; set; }

    [XmlElement("SexAssaultByCarnalAbuse")]
    public RiskFlagInfo SexAssaultByCarnalAbuse { get; set; }

    [XmlElement("RapeOfElderlyPerson")]
    public RiskFlagInfo RapeOfElderlyPerson { get; set; }

    [XmlElement("RapeOfDisabledPerson")]
    public RiskFlagInfo RapeOfDisabledPerson { get; set; }

    [XmlElement("SexAssaultElderlyPerson")]
    public RiskFlagInfo SexAssaultElderlyPerson { get; set; }

    [XmlElement("SexAssaultDisabledPerson")]
    public RiskFlagInfo SexAssaultDisabledPerson { get; set; }

    [XmlElement("DrugInducedRape")]
    public RiskFlagInfo DrugInducedRape { get; set; }

    [XmlElement("DrugInducedSexAssault")]
    public RiskFlagInfo DrugInducedSexAssault { get; set; }

    [XmlElement("Rape")]
    public RiskFlagInfo Rape { get; set; }

    [XmlElement("SexAssault")]
    public RiskFlagInfo SexAssault { get; set; }

    [XmlElement("SexAssaultMinor")]
    public RiskFlagInfo SexAssaultMinor { get; set; }

}
}