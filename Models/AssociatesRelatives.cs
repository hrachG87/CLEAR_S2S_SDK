using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AssociatesRelatives")]
public class AssociatesRelatives
{
    [XmlElement("AssocRelWithWCBlacklisted")]
    public RiskFlagInfo AssocRelWithWCBlacklisted { get; set; }

    [XmlElement("AssocRelWithWCCrimeFinancial")]
    public RiskFlagInfo AssocRelWithWCCrimeFinancial { get; set; }

    [XmlElement("AssocRelWithWCCrimeNarcotics")]
    public RiskFlagInfo AssocRelWithWCCrimeNarcotics { get; set; }

    [XmlElement("AssocRelWithWCCrimeOrganized")]
    public RiskFlagInfo AssocRelWithWCCrimeOrganized { get; set; }

    [XmlElement("AssocRelWithWCCrimeOther")]
    public RiskFlagInfo AssocRelWithWCCrimeOther { get; set; }

    [XmlElement("AssocRelWithWCCrimeWar")]
    public RiskFlagInfo AssocRelWithWCCrimeWar { get; set; }

    [XmlElement("AssocRelWithWCDiplomat")]
    public RiskFlagInfo AssocRelWithWCDiplomat { get; set; }

    [XmlElement("AssocRelWithWCIndividual")]
    public RiskFlagInfo AssocRelWithWCIndividual { get; set; }

    [XmlElement("AssocRelWithWCLegal")]
    public RiskFlagInfo AssocRelWithWCLegal { get; set; }

    [XmlElement("AssocRelWithWCMilitary")]
    public RiskFlagInfo AssocRelWithWCMilitary { get; set; }

    [XmlElement("AssocRelWithWCPoliticalIndividual")]
    public RiskFlagInfo AssocRelWithWCPoliticalIndividual { get; set; }

    [XmlElement("AssocRelWithWCReligion")]
    public RiskFlagInfo AssocRelWithWCReligion { get; set; }

    [XmlElement("AssocRelWithWCCrimeTerror")]
    public RiskFlagInfo AssocRelWithWCCrimeTerror { get; set; }

    [XmlElement("AssocRelWithWCNonconvictionTerror")]
    public RiskFlagInfo AssocRelWithWCNonconvictionTerror { get; set; }

    [XmlElement("AssocRelWithPepUSACrimeFinancial")]
    public RiskFlagInfo AssocRelWithPepUSACrimeFinancial { get; set; }

    [XmlElement("AssocRelWithPepUSACrimeNarcotics")]
    public RiskFlagInfo AssocRelWithPepUSACrimeNarcotics { get; set; }

    [XmlElement("AssocRelWithPepUSACrimeOrganized")]
    public RiskFlagInfo AssocRelWithPepUSACrimeOrganized { get; set; }

    [XmlElement("AssocRelWithPepUSACrimeOther")]
    public RiskFlagInfo AssocRelWithPepUSACrimeOther { get; set; }

    [XmlElement("AssocRelWithPepUSACrimeWar")]
    public RiskFlagInfo AssocRelWithPepUSACrimeWar { get; set; }

    [XmlElement("AssocRelWithPepUSADiplomat")]
    public RiskFlagInfo AssocRelWithPepUSADiplomat { get; set; }

    [XmlElement("AssocRelWithPepUSAIndividual")]
    public RiskFlagInfo AssocRelWithPepUSAIndividual { get; set; }

    [XmlElement("AssocRelWithPepUSALegal")]
    public RiskFlagInfo AssocRelWithPepUSALegal { get; set; }

    [XmlElement("AssocRelWithPepUSAMilitary")]
    public RiskFlagInfo AssocRelWithPepUSAMilitary { get; set; }

    [XmlElement("AssocRelWithPepUSAPoliticalIndividual")]
    public RiskFlagInfo AssocRelWithPepUSAPoliticalIndividual { get; set; }

    [XmlElement("AssocRelWithPepUSAReligion")]
    public RiskFlagInfo AssocRelWithPepUSAReligion { get; set; }

    [XmlElement("AssocRelWithPepUSACrimeTerror")]
    public RiskFlagInfo AssocRelWithPepUSACrimeTerror { get; set; }

    [XmlElement("AssocRelWithPepUSANonconvictionTerror")]
    public RiskFlagInfo AssocRelWithPepUSANonconvictionTerror { get; set; }

    [XmlElement("AssocRelWithPepIntlCrimeFinancial")]
    public RiskFlagInfo AssocRelWithPepIntlCrimeFinancial { get; set; }

    [XmlElement("AssocRelWithPepIntlCrimeNarcotics")]
    public RiskFlagInfo AssocRelWithPepIntlCrimeNarcotics { get; set; }

    [XmlElement("AssocRelWithPepIntlCrimeOrganized")]
    public RiskFlagInfo AssocRelWithPepIntlCrimeOrganized { get; set; }

    [XmlElement("AssocRelWithPepIntlCrimeOther")]
    public RiskFlagInfo AssocRelWithPepIntlCrimeOther { get; set; }

    [XmlElement("AssocRelWithPepIntlCrimeWar")]
    public RiskFlagInfo AssocRelWithPepIntlCrimeWar { get; set; }

    [XmlElement("AssocRelWithPepIntlDiplomat")]
    public RiskFlagInfo AssocRelWithPepIntlDiplomat { get; set; }

    [XmlElement("AssocRelWithPepIntlIndividual")]
    public RiskFlagInfo AssocRelWithPepIntlIndividual { get; set; }

    [XmlElement("AssocRelWithPepIntlLegal")]
    public RiskFlagInfo AssocRelWithPepIntlLegal { get; set; }

    [XmlElement("AssocRelWithPepIntlMilitary")]
    public RiskFlagInfo AssocRelWithPepIntlMilitary { get; set; }

    [XmlElement("AssocRelWithPepIntlPoliticalIndividual")]
    public RiskFlagInfo AssocRelWithPepIntlPoliticalIndividual { get; set; }

    [XmlElement("AssocRelWithPepIntlReligion")]
    public RiskFlagInfo AssocRelWithPepIntlReligion { get; set; }

    [XmlElement("AssocRelWithPepIntlCrimeTerror")]
    public RiskFlagInfo AssocRelWithPepIntlCrimeTerror { get; set; }

    [XmlElement("AssocRelWithPepIntlNonconvictionTerror")]
    public RiskFlagInfo AssocRelWithPepIntlNonconvictionTerror { get; set; }

    [XmlElement("AssociateRelativeWithGlobalSanctions")]
    public RiskFlagInfo AssociateRelativeWithGlobalSanctions { get; set; }

    [XmlElement("AssociateRelativeWithOFAC")]
    public RiskFlagInfo AssociateRelativeWithOFAC { get; set; }

}
}