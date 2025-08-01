using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Sanctions")]
public class Sanctions
{
    [XmlElement("WorldCheckBlacklisted")]
    public RiskFlagInfo WorldCheckBlacklisted { get; set; }

    [XmlElement("WorldCheckCrimeFinancial")]
    public RiskFlagInfo WorldCheckCrimeFinancial { get; set; }

    [XmlElement("WorldCheckCrimeNarcotics")]
    public RiskFlagInfo WorldCheckCrimeNarcotics { get; set; }

    [XmlElement("WorldCheckCrimeOrganized")]
    public RiskFlagInfo WorldCheckCrimeOrganized { get; set; }

    [XmlElement("WorldCheckCrimeOther")]
    public RiskFlagInfo WorldCheckCrimeOther { get; set; }

    [XmlElement("WorldCheckCrimeWar")]
    public RiskFlagInfo WorldCheckCrimeWar { get; set; }

    [XmlElement("WorldCheckDiplomat")]
    public RiskFlagInfo WorldCheckDiplomat { get; set; }

    [XmlElement("WorldCheckIndividual")]
    public RiskFlagInfo WorldCheckIndividual { get; set; }

    [XmlElement("WorldCheckLegal")]
    public RiskFlagInfo WorldCheckLegal { get; set; }

    [XmlElement("WorldCheckMilitary")]
    public RiskFlagInfo WorldCheckMilitary { get; set; }

    [XmlElement("WorldCheckPoliticalIndividual")]
    public RiskFlagInfo WorldCheckPoliticalIndividual { get; set; }

    [XmlElement("WorldCheckReligion")]
    public RiskFlagInfo WorldCheckReligion { get; set; }

    [XmlElement("WorldCheckCrimeTerror")]
    public RiskFlagInfo WorldCheckCrimeTerror { get; set; }

    [XmlElement("WorldCheckNonconvictionTerror")]
    public RiskFlagInfo WorldCheckNonconvictionTerror { get; set; }

    [XmlElement("GlobalSanctions")]
    public RiskFlagInfo GlobalSanctions { get; set; }

    [XmlElement("OFACRecord")]
    public RiskFlagInfo OFACRecord { get; set; }

}