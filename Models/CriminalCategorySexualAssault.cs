using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategorySexualAssault")]
public class CriminalCategorySexualAssault
{
    [XmlElement("RapeWithGun")]
    public CriminalChargetypes RapeWithGun { get; set; }

    [XmlElement("RapeWithWeapon")]
    public CriminalChargetypes RapeWithWeapon { get; set; }

    [XmlElement("StrongArmRape")]
    public CriminalChargetypes StrongArmRape { get; set; }

    [XmlElement("SexAssaultSodomyBoyWithGun")]
    public CriminalChargetypes SexAssaultSodomyBoyWithGun { get; set; }

    [XmlElement("SexAssaultSodomyManWithGun")]
    public CriminalChargetypes SexAssaultSodomyManWithGun { get; set; }

    [XmlElement("SexAssaultSodomyGirlWithGun")]
    public CriminalChargetypes SexAssaultSodomyGirlWithGun { get; set; }

    [XmlElement("SexAssaultSodomyWomanWithGun")]
    public CriminalChargetypes SexAssaultSodomyWomanWithGun { get; set; }

    [XmlElement("SexAssaultSodomyBoyWithWeapon")]
    public CriminalChargetypes SexAssaultSodomyBoyWithWeapon { get; set; }

    [XmlElement("SexAssaultSodomyManWithWeapon")]
    public CriminalChargetypes SexAssaultSodomyManWithWeapon { get; set; }

    [XmlElement("SexAssaultSodomyGirlWithWeapon")]
    public CriminalChargetypes SexAssaultSodomyGirlWithWeapon { get; set; }

    [XmlElement("SexAssaultSodomyWomanWithWeapon")]
    public CriminalChargetypes SexAssaultSodomyWomanWithWeapon { get; set; }

    [XmlElement("StrongarmSexAssaultSodomyBoy")]
    public CriminalChargetypes StrongarmSexAssaultSodomyBoy { get; set; }

    [XmlElement("StrongarmSexAssaultSodomyMan")]
    public CriminalChargetypes StrongarmSexAssaultSodomyMan { get; set; }

    [XmlElement("StrongarmSexAssaultSodomyGirl")]
    public CriminalChargetypes StrongarmSexAssaultSodomyGirl { get; set; }

    [XmlElement("StrongarmSexAssaultSodomyWoman")]
    public CriminalChargetypes StrongarmSexAssaultSodomyWoman { get; set; }

    [XmlElement("StatutoryRapeWithoutForce")]
    public CriminalChargetypes StatutoryRapeWithoutForce { get; set; }

    [XmlElement("SexAssaultByCarnalAbuse")]
    public CriminalChargetypes SexAssaultByCarnalAbuse { get; set; }

    [XmlElement("RapeOfElderlyPerson")]
    public CriminalChargetypes RapeOfElderlyPerson { get; set; }

    [XmlElement("RapeOfDisablePerson")]
    public CriminalChargetypes RapeOfDisablePerson { get; set; }

    [XmlElement("SexAssaultElderlyPerson")]
    public CriminalChargetypes SexAssaultElderlyPerson { get; set; }

    [XmlElement("SexAssaultDisablePerson")]
    public CriminalChargetypes SexAssaultDisablePerson { get; set; }

    [XmlElement("DrugInducedRape")]
    public CriminalChargetypes DrugInducedRape { get; set; }

    [XmlElement("DrugInducesSexAssault")]
    public CriminalChargetypes DrugInducesSexAssault { get; set; }

    [XmlElement("SexAssaultMinor")]
    public CriminalChargetypes SexAssaultMinor { get; set; }

    [XmlElement("Rape")]
    public CriminalChargetypes Rape { get; set; }

    [XmlElement("SexAssault")]
    public CriminalChargetypes SexAssault { get; set; }

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