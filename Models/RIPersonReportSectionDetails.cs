using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RIPersonReportSectionDetails")]
public class RIPersonReportSectionDetails
{
    [XmlElement("AddressSection")]
    public AddressSection AddressSection { get; set; }

    [XmlElement("AssociateAnalyticsChartSection")]
    public PersonReportAssociateAnalyticsChartSection AssociateAnalyticsChartSection { get; set; }

    [XmlElement("AssociateSection")]
    public AssociateSection AssociateSection { get; set; }

    [XmlElement("DivorceSection")]
    public DivorceSection DivorceSection { get; set; }

    [XmlElement("FcraSection")]
    public FcraSection FcraSection { get; set; }

    [XmlElement("LicenseSection")]
    public LicenseSection LicenseSection { get; set; }

    [XmlElement("MarriageSection")]
    public MarriageSection MarriageSection { get; set; }

    [XmlElement("NeighborSection")]
    public NeighborSection NeighborSection { get; set; }

    [XmlElement("PhoneListingSection")]
    public PhoneListingSection PhoneListingSection { get; set; }

    [XmlElement("ProfessionalLicenseSection")]
    public ProfessionalLicenseSection ProfessionalLicenseSection { get; set; }

    [XmlElement("RealTimeArrestSection")]
    public PersonRealTimeArrestSection RealTimeArrestSection { get; set; }

    [XmlElement("RelativeSection")]
    public RelativeSection RelativeSection { get; set; }

    [XmlElement("RiskInformCriminalHistoryDetails")]
    public RiskInformCriminalHistoryDetailsV3 RiskInformCriminalHistoryDetails { get; set; }

    [XmlElement("RiskInformCustomDetails")]
    public RIPersonReportCustomDetailsV3 RiskInformCustomDetails { get; set; }

    [XmlElement("RiskInformDangerousCriminalHistoryDetails")]
    public RiskInformDangerousCriminalHistoryDetailsV3 RiskInformDangerousCriminalHistoryDetails { get; set; }

    [XmlElement("RiskInformFinancialCrimesDetails")]
    public RiskInformFinancialCrimesDetailsV3 RiskInformFinancialCrimesDetails { get; set; }

    [XmlElement("RiskInformGovProcurementFraudDetails")]
    public RiskInformGovProcurementFraudDetailsV3 RiskInformGovProcurementFraudDetails { get; set; }

    [XmlElement("RiskInformHealthcareFraudDetails")]
    public RiskInformHealthcareFraudDetailsV3 RiskInformHealthcareFraudDetails { get; set; }

    [XmlElement("RiskInformInsuranceFraudDetails")]
    public RiskInformInsuranceFraudDetailsV3 RiskInformInsuranceFraudDetails { get; set; }

    [XmlElement("RiskInformLitigiousIndividualDetails")]
    public RiskInformLitigiousIndividualDetailsV3 RiskInformLitigiousIndividualDetails { get; set; }

    [XmlElement("RiskInformMortgageFraudDetails")]
    public RiskInformMortgageFraudDetailsV3 RiskInformMortgageFraudDetails { get; set; }

    [XmlElement("RiskInformNewsDetails")]
    public RIPersonReportNewsDetails RiskInformNewsDetails { get; set; }

    [XmlElement("RiskInformPropertyCrimesDetails")]
    public RiskInformPropertyCrimesDetailsV3 RiskInformPropertyCrimesDetails { get; set; }

    [XmlElement("RiskInformScore")]
    public RIPersonReportScore RiskInformScore { get; set; }

    [XmlElement("RiskInformAddressDetails")]
    public RIPersonReportAddressDetails RiskInformAddressDetails { get; set; }

    [XmlElement("RiskInformSingleRiskIndicatorsDetails")]
    public RIPersonReportSingleRiskIndicatorsDetails RiskInformSingleRiskIndicatorsDetails { get; set; }

    [XmlElement("RiskInformSummary")]
    public RiskInformSummary RiskInformSummary { get; set; }

    [XmlElement("RiskInformSyntheticIDDetails")]
    public RiskInformSyntheticIDDetails RiskInformSyntheticIDDetails { get; set; }

    [XmlElement("RiskInformTaxFraudDetails")]
    public RiskInformTaxFraudDetailsV3 RiskInformTaxFraudDetails { get; set; }

    [XmlElement("RiskInformWebAnalyticsDetails")]
    public RIPersonReportWebAnalyticsDetails RiskInformWebAnalyticsDetails { get; set; }

    [XmlElement("SubjectSection")]
    public SubjectSection SubjectSection { get; set; }

    [XmlElement("UserTermsSection")]
    public PersonUserTermsSection UserTermsSection { get; set; }

    [XmlElement("UtilitySection")]
    public UtilitySection UtilitySection { get; set; }

    [XmlElement("WorkAffiliationSection")]
    public WorkAffiliationSection WorkAffiliationSection { get; set; }

    [XmlElement("PermissiblePurposeSection")]
    public PersonPermissiblePurposeSection PermissiblePurposeSection { get; set; }

    [XmlElement("PersonOverviewSection")]
    public PersonOverviewSection PersonOverviewSection { get; set; }

    [XmlElement("PhoneNumbersSection")]
    public PhoneNumbersSection PhoneNumbersSection { get; set; }

    [XmlElement("EmailAddressesSection")]
    public EmailAddressesSection EmailAddressesSection { get; set; }

    [XmlElement("UsernamesSection")]
    public UsernamesSection UsernamesSection { get; set; }

    [XmlElement("JobsSection")]
    public JobsSection JobsSection { get; set; }

    [XmlElement("EducationSection")]
    public EducationSection EducationSection { get; set; }

    [XmlElement("InterestsSection")]
    public InterestsSection InterestsSection { get; set; }

    [XmlElement("SocialNetworkProfilesDetailsSection")]
    public SocialNetworkProfilesDetailsSection SocialNetworkProfilesDetailsSection { get; set; }

    [XmlElement("GeoSocialNetworksDetailsSection")]
    public GeoSocialNetworksDetailsSection GeoSocialNetworksDetailsSection { get; set; }

    [XmlElement("NewsMediaDetailsSection")]
    public NewsMediaDetailsSection NewsMediaDetailsSection { get; set; }

    [XmlElement("BloggingForumsDetailsSection")]
    public BloggingForumsDetailsSection BloggingForumsDetailsSection { get; set; }

    [XmlElement("MicroBloggingDetailsSection")]
    public MicroBloggingDetailsSection MicroBloggingDetailsSection { get; set; }

    [XmlElement("PictureVideoSharingDetailsSection")]
    public PictureVideoSharingDetailsSection PictureVideoSharingDetailsSection { get; set; }

    [XmlElement("OnlineCommerceDetailsSection")]
    public OnlineCommerceDetailsSection OnlineCommerceDetailsSection { get; set; }

    [XmlElement("MusicDetailsSection")]
    public MusicDetailsSection MusicDetailsSection { get; set; }

    [XmlElement("OtherDetailsSection")]
    public OtherDetailsSection OtherDetailsSection { get; set; }

    [XmlElement("NoMatchSections")]
    public NoMatchSections NoMatchSections { get; set; }
}
