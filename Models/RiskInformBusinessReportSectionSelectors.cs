using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformBusinessReportSectionSelectors")]
public class RiskInformBusinessReportSectionSelectors
{
    [XmlElement("RiskInformScore")]
    public bool RiskInformScore { get; set; }

    [XmlElement("RiskInformSummary")]
    public bool RiskInformSummary { get; set; }

    [XmlElement("RiskInformAddressDetails")]
    public bool RiskInformAddressDetails { get; set; }

    [XmlElement("RiskInformCompanyDetailsAndStructureDetails")]
    public bool RiskInformCompanyDetailsAndStructureDetails { get; set; }

    [XmlElement("RiskInformPrincipalsAndExecutivesTiedToBusinessDetails")]
    public bool RiskInformPrincipalsAndExecutivesTiedToBusinessDetails { get; set; }

    [XmlElement("RiskInformSingleRiskIndicatorsDetails")]
    public bool RiskInformSingleRiskIndicatorsDetails { get; set; }

    [XmlElement("RiskInformBusinessRiskDetails")]
    public bool RiskInformBusinessRiskDetails { get; set; }

    [XmlElement("RiskInformHealthcareRiskDetails")]
    public bool RiskInformHealthcareRiskDetails { get; set; }

    [XmlElement("RiskInformPartyToRiskBasedLawsuitsDetails")]
    public bool RiskInformPartyToRiskBasedLawsuitsDetails { get; set; }

    [XmlElement("RiskInformCustomDetails")]
    public bool RiskInformCustomDetails { get; set; }

    [XmlElement("RiskInformNewsDetails")]
    public bool RiskInformNewsDetails { get; set; }

    [XmlElement("RiskInformWebAnalyticsDetails")]
    public bool RiskInformWebAnalyticsDetails { get; set; }

    [XmlElement("PhoneNumberSection")]
    public bool PhoneNumberSection { get; set; }

    [XmlElement("BusinessSameAddressSection")]
    public bool BusinessSameAddressSection { get; set; }

    [XmlElement("PeopleSameAddressSection")]
    public bool PeopleSameAddressSection { get; set; }

    [XmlElement("BusinessSamePhoneSection")]
    public bool BusinessSamePhoneSection { get; set; }

    [XmlElement("PeopleSamePhoneSection")]
    public bool PeopleSamePhoneSection { get; set; }

    [XmlElement("AssociateAnalyticsChartSection")]
    public bool AssociateAnalyticsChartSection { get; set; }

    [XmlElement("DocketSection")]
    public bool DocketSection { get; set; }

    [XmlElement("NoMatchSections")]
    public bool NoMatchSections { get; set; }
}
