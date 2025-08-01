using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformPersonReportSectionSelectors")]
public class RiskInformPersonReportSectionSelectors
{
    [XmlElement("RiskInformScore")]
    public bool RiskInformScore { get; set; }

    [XmlElement("RiskInformSummary")]
    public bool RiskInformSummary { get; set; }

    [XmlElement("RiskInformCustomDetails")]
    public bool RiskInformCustomDetails { get; set; }

    [XmlElement("RiskInformHealthcareFraudDetails")]
    public bool RiskInformHealthcareFraudDetails { get; set; }

    [XmlElement("RiskInformCriminalHistoryDetails")]
    public bool RiskInformCriminalHistoryDetails { get; set; }

    [XmlElement("RiskInformDangerousCriminalHistoryDetails")]
    public bool RiskInformDangerousCriminalHistoryDetails { get; set; }

    [XmlElement("RiskInformFinancialCrimesDetails")]
    public bool RiskInformFinancialCrimesDetails { get; set; }

    [XmlElement("RiskInformGovProcurementFraudDetails")]
    public bool RiskInformGovProcurementFraudDetails { get; set; }

    [XmlElement("RiskInformMortgageFraudDetails")]
    public bool RiskInformMortgageFraudDetails { get; set; }

    [XmlElement("RiskInformLitigiousIndividualDetails")]
    public bool RiskInformLitigiousIndividualDetails { get; set; }

    [XmlElement("RiskInformPropertyCrimesDetails")]
    public bool RiskInformPropertyCrimesDetails { get; set; }

    [XmlElement("RiskInformInsuranceFraudDetails")]
    public bool RiskInformInsuranceFraudDetails { get; set; }

    [XmlElement("RiskInformTaxFraudDetails")]
    public bool RiskInformTaxFraudDetails { get; set; }

    [XmlElement("RiskInformNewsDetails")]
    public bool RiskInformNewsDetails { get; set; }

    [XmlElement("RiskInformAddressDetails")]
    public bool RiskInformAddressDetails { get; set; }

    [XmlElement("RiskInformSingleRiskIndicatorsDetails")]
    public bool RiskInformSingleRiskIndicatorsDetails { get; set; }

    [XmlElement("RiskInformSyntheticIDDetails")]
    public bool RiskInformSyntheticIDDetails { get; set; }

    [XmlElement("RiskInformWebAnalyticsDetails")]
    public bool RiskInformWebAnalyticsDetails { get; set; }

    [XmlElement("AddressSection")]
    public bool AddressSection { get; set; }

    [XmlElement("PhoneListingSection")]
    public bool PhoneListingSection { get; set; }

    [XmlElement("UtilitySection")]
    public bool UtilitySection { get; set; }

    [XmlElement("MarriageSection")]
    public bool MarriageSection { get; set; }

    [XmlElement("DivorceSection")]
    public bool DivorceSection { get; set; }

    [XmlElement("LicenseSection")]
    public bool LicenseSection { get; set; }

    [XmlElement("WorkAffiliationSection")]
    public bool WorkAffiliationSection { get; set; }

    [XmlElement("RelativeSection")]
    public bool RelativeSection { get; set; }

    [XmlElement("AssociateSection")]
    public bool AssociateSection { get; set; }

    [XmlElement("NeighborSection")]
    public bool NeighborSection { get; set; }

    [XmlElement("AssociateAnalyticsChartSection")]
    public bool AssociateAnalyticsChartSection { get; set; }

    [XmlElement("RealTimeArrestSection")]
    public bool RealTimeArrestSection { get; set; }

    [XmlElement("WebAnalyticsSection")]
    public bool WebAnalyticsSection { get; set; }

    [XmlElement("PermissiblePurposeSection")]
    public bool PermissiblePurposeSection { get; set; }

    [XmlElement("WebAndSocialMediaPersonOverviewSection")]
    public bool WebAndSocialMediaPersonOverviewSection { get; set; }

    [XmlElement("WebAndSocialMediaPhoneNumbersSection")]
    public bool WebAndSocialMediaPhoneNumbersSection { get; set; }

    [XmlElement("WebAndSocialMediaEmailAddressesSection")]
    public bool WebAndSocialMediaEmailAddressesSection { get; set; }

    [XmlElement("WebAndSocialMediaUsernamesSection")]
    public bool WebAndSocialMediaUsernamesSection { get; set; }

    [XmlElement("WebAndSocialMediaJobsSection")]
    public bool WebAndSocialMediaJobsSection { get; set; }

    [XmlElement("WebAndSocialMediaEducationSection")]
    public bool WebAndSocialMediaEducationSection { get; set; }

    [XmlElement("WebAndSocialMediaInterestsSection")]
    public bool WebAndSocialMediaInterestsSection { get; set; }

    [XmlElement("WebAndSocialMediaSocialNetworkProfilesDetailsSection")]
    public bool WebAndSocialMediaSocialNetworkProfilesDetailsSection { get; set; }

    [XmlElement("WebAndSocialMediaGeoSocialNetworksDetailsSection")]
    public bool WebAndSocialMediaGeoSocialNetworksDetailsSection { get; set; }

    [XmlElement("WebAndSocialMediaNewsMediaDetailsSection")]
    public bool WebAndSocialMediaNewsMediaDetailsSection { get; set; }

    [XmlElement("WebAndSocialMediaBloggingForumsDetailsSection")]
    public bool WebAndSocialMediaBloggingForumsDetailsSection { get; set; }

    [XmlElement("WebAndSocialMediaMicroBloggingDetailsSection")]
    public bool WebAndSocialMediaMicroBloggingDetailsSection { get; set; }

    [XmlElement("WebAndSocialMediaPictureVideoSharingDetailsSection")]
    public bool WebAndSocialMediaPictureVideoSharingDetailsSection { get; set; }

    [XmlElement("WebAndSocialMediaOnlineCommerceDetailsSection")]
    public bool WebAndSocialMediaOnlineCommerceDetailsSection { get; set; }

    [XmlElement("WebAndSocialMediaMusicDetailsSection")]
    public bool WebAndSocialMediaMusicDetailsSection { get; set; }

    [XmlElement("WebAndSocialMediaOtherDetailsSection")]
    public bool WebAndSocialMediaOtherDetailsSection { get; set; }

    [XmlElement("NoMatchSections")]
    public bool NoMatchSections { get; set; }
}
