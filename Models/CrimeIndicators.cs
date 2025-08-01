using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CrimeIndicators")]
public class CrimeIndicators
{
    [XmlElement("AttemptedCrime")]
    public string AttemptedCrime { get; set; }

    [XmlElement("DrugCrime")]
    public string DrugCrime { get; set; }

    [XmlElement("GuiltyButMentallyIll")]
    public string GuiltyButMentallyIll { get; set; }

    [XmlElement("HateCrime")]
    public string HateCrime { get; set; }

    [XmlElement("InchoateCrime")]
    public string InchoateCrime { get; set; }

    [XmlElement("OtherCrimeInfo")]
    public string OtherCrimeInfo { get; set; }

    [XmlElement("PropertyCrime")]
    public string PropertyCrime { get; set; }

    [XmlElement("PropertySeized")]
    public string PropertySeized { get; set; }

    [XmlElement("RiskLevel")]
    public string RiskLevel { get; set; }

    [XmlElement("SecondFelony")]
    public string SecondFelony { get; set; }

    [XmlElement("SexCrime")]
    public string SexCrime { get; set; }

    [XmlElement("VictimAgeDesc")]
    public string VictimAgeDesc { get; set; }

    [XmlElement("VictimGender")]
    public string VictimGender { get; set; }

    [XmlElement("VictimIsaMinor")]
    public string VictimIsaMinor { get; set; }

    [XmlElement("WeaponCrime")]
    public string WeaponCrime { get; set; }
}
