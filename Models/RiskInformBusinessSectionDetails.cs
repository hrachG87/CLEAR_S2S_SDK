using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformBusinessSectionDetails")]
public class RiskInformBusinessSectionDetails
{
    [XmlElement("AssociateAnalyticsChartSection")]
    public CompanyReportAssociateAnalyticsChartSection AssociateAnalyticsChartSection { get; set; }

    [XmlElement("BusinessOverviewSection")]
    public BusinessOverviewSection BusinessOverviewSection { get; set; }

    [XmlElement("BusinessSameAddressSection")]
    public BusinessSameAddressSection BusinessSameAddressSection { get; set; }

    [XmlElement("BusinessSamePhoneSection")]
    public BusinessSamePhoneSection BusinessSamePhoneSection { get; set; }

    [XmlElement("DocketSection")]
    public CompanyReportDocketSection DocketSection { get; set; }

    [XmlElement("PeopleSameAddressSection")]
    public PeopleSameAddressSection PeopleSameAddressSection { get; set; }

    [XmlElement("PeopleSamePhoneSection")]
    public PeopleSamePhoneSection PeopleSamePhoneSection { get; set; }

    [XmlElement("PhoneNumberSection")]
    public CompanyPhoneNumberSection PhoneNumberSection { get; set; }

    [XmlElement("RiskInformAddressDetails")]
    public RiskInformAddressDetails RiskInformAddressDetails { get; set; }

    [XmlElement("RiskInformBusinessRiskDetails")]
    public RiskInformBusinessRiskDetails RiskInformBusinessRiskDetails { get; set; }

    [XmlElement("RiskInformCompanyDetailsAndStructureDetails")]
    public RiskInformCompanyDetailsAndStructureDetails RiskInformCompanyDetailsAndStructureDetails { get; set; }

    [XmlElement("RiskInformCustomDetails")]
    public RiskInformCustomDetails RiskInformCustomDetails { get; set; }

    [XmlElement("RiskInformHealthcareRiskDetails")]
    public RiskInformHealthcareRiskDetails RiskInformHealthcareRiskDetails { get; set; }

    [XmlElement("RiskInformNewsDetails")]
    public RiskInformNewsDetails RiskInformNewsDetails { get; set; }

    [XmlElement("RiskInformPartyToRiskBasedLawsuitsDetails")]
    public RiskInformPartyToRiskBasedLawsuitsDetails RiskInformPartyToRiskBasedLawsuitsDetails { get; set; }

    [XmlElement("RiskInformPrincipalsAndExecutivesTiedToBusinessDetails")]
    public RiskInformPrincipalsAndExecutivesTiedToBusinessDetails RiskInformPrincipalsAndExecutivesTiedToBusinessDetails { get; set; }

    [XmlElement("RiskInformScore")]
    public RiskInformScore RiskInformScore { get; set; }

    [XmlElement("RiskInformSingleRiskIndicatorsDetails")]
    public RiskInformSingleRiskIndicatorsDetails RiskInformSingleRiskIndicatorsDetails { get; set; }

    [XmlElement("RiskInformSummary")]
    public RiskInformSummary RiskInformSummary { get; set; }

    [XmlElement("RiskInformWebAnalyticsDetails")]
    public RiskInformWebAnalyticsDetails RiskInformWebAnalyticsDetails { get; set; }

    [XmlElement("UserTermsSection")]
    public CompanyUserTermsSection UserTermsSection { get; set; }

    [XmlElement("NoMatchSections")]
    public NoMatchSections NoMatchSections { get; set; }

}