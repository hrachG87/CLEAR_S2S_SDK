using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaMonitorReportSectionDetails")]
public class AdverseMediaMonitorReportSectionDetails
{
    [XmlElement("AdverseMediaMonitorUserTermsSection")]
    public AdverseMediaMonitorUserTermsSection AdverseMediaMonitorUserTermsSection { get; set; }

    [XmlElement("AdverseMediaMonitorSummarySection")]
    public AdverseMediaMonitorSummarySection AdverseMediaMonitorSummarySection { get; set; }

    [XmlElement("AdverseMediaMonitorArticlesSection")]
    public AdverseMediaMonitorArticlesSection AdverseMediaMonitorArticlesSection { get; set; }

    [XmlElement("AntitrustViolationsSection")]
    public AdverseMediaArticleCategorySection AntitrustViolationsSection { get; set; }

    [XmlElement("ArmsTraffickingSection")]
    public AdverseMediaArticleCategorySection ArmsTraffickingSection { get; set; }

    [XmlElement("BriberyCorruptionSection")]
    public AdverseMediaArticleCategorySection BriberyCorruptionSection { get; set; }

    [XmlElement("CivilLawsuitSection")]
    public AdverseMediaArticleCategorySection CivilLawsuitSection { get; set; }

    [XmlElement("CurrencyCounterfeitingSection")]
    public AdverseMediaArticleCategorySection CurrencyCounterfeitingSection { get; set; }

    [XmlElement("CybercrimeHackingPhishingSection")]
    public AdverseMediaArticleCategorySection CybercrimeHackingPhishingSection { get; set; }

    [XmlElement("DrugNarcoticsTraffickingSection")]
    public AdverseMediaArticleCategorySection DrugNarcoticsTraffickingSection { get; set; }

    [XmlElement("EmbezzlementSection")]
    public AdverseMediaArticleCategorySection EmbezzlementSection { get; set; }

    [XmlElement("EnvironmentalCrimesSection")]
    public AdverseMediaArticleCategorySection EnvironmentalCrimesSection { get; set; }

    [XmlElement("ExtortionSection")]
    public AdverseMediaArticleCategorySection ExtortionSection { get; set; }

    [XmlElement("FalsifyingInfoSection")]
    public AdverseMediaArticleCategorySection FalsifyingInfoSection { get; set; }

    [XmlElement("ForgerySection")]
    public AdverseMediaArticleCategorySection ForgerySection { get; set; }

    [XmlElement("FraudSection")]
    public AdverseMediaArticleCategorySection FraudSection { get; set; }

    [XmlElement("HostageKidnappingSection")]
    public AdverseMediaArticleCategorySection HostageKidnappingSection { get; set; }

    [XmlElement("HumanTraffickingSection")]
    public AdverseMediaArticleCategorySection HumanTraffickingSection { get; set; }

    [XmlElement("IllicitTraffickingSection")]
    public AdverseMediaArticleCategorySection IllicitTraffickingSection { get; set; }

    [XmlElement("MoneyLaunderingSection")]
    public AdverseMediaArticleCategorySection MoneyLaunderingSection { get; set; }

    [XmlElement("RacketeeringSection")]
    public AdverseMediaArticleCategorySection RacketeeringSection { get; set; }

    [XmlElement("PharmaTraffickingSection")]
    public AdverseMediaArticleCategorySection PharmaTraffickingSection { get; set; }

    [XmlElement("PiracyCounterfeitingSection")]
    public AdverseMediaArticleCategorySection PiracyCounterfeitingSection { get; set; }

    [XmlElement("RobberyTheftSection")]
    public AdverseMediaArticleCategorySection RobberyTheftSection { get; set; }

    [XmlElement("SanctionViolationsSection")]
    public AdverseMediaArticleCategorySection SanctionViolationsSection { get; set; }

    [XmlElement("SecuritiesFraudInsiderTradeSection")]
    public AdverseMediaArticleCategorySection SecuritiesFraudInsiderTradeSection { get; set; }

    [XmlElement("TaxEvasionFraudSection")]
    public AdverseMediaArticleCategorySection TaxEvasionFraudSection { get; set; }

    [XmlElement("TerrorismFinancingSection")]
    public AdverseMediaArticleCategorySection TerrorismFinancingSection { get; set; }

    [XmlElement("WarCrimesSection")]
    public AdverseMediaArticleCategorySection WarCrimesSection { get; set; }

    [XmlElement("MultipleTagsSection")]
    public AdverseMediaArticleCategorySection MultipleTagsSection { get; set; }

    [XmlElement("UntaggedSection")]
    public AdverseMediaArticleCategorySection UntaggedSection { get; set; }

    [XmlElement("SanctionSection")]
    public SanctionSection SanctionSection { get; set; }

    [XmlElement("StateOwnedEntitySection")]
    public StateOwnedEntitySection StateOwnedEntitySection { get; set; }

    [XmlElement("PoliticallyExposedPersonSection")]
    public PoliticallyExposedPersonSection PoliticallyExposedPersonSection { get; set; }

    [XmlElement("FcraSection")]
    public FcraSection FcraSection { get; set; }

}
}