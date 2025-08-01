using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SectionDetails")]
public class SectionDetails
{
    [XmlElement("AddressSection")]
    public AddressSection AddressSection { get; set; }

    [XmlElement("AircraftSection")]
    public PersonReportAircraftSection AircraftSection { get; set; }

    [XmlElement("ArrestSection")]
    public PersonReportArrestSection ArrestSection { get; set; }

    [XmlElement("AssociateAnalyticsChartSection")]
    public PersonReportAssociateAnalyticsChartSection AssociateAnalyticsChartSection { get; set; }

    [XmlElement("AssociateSection")]
    public AssociateSection AssociateSection { get; set; }

    [XmlElement("BankruptcySection")]
    public PersonReportBankruptcySection BankruptcySection { get; set; }

    [XmlElement("BusinessAtSubjectAddressSection")]
    public BusinessAtSubjectAddressSection BusinessAtSubjectAddressSection { get; set; }

    [XmlElement("BusinessContactRecordsSection")]
    public PersonReportBusinessContactRecordsSection BusinessContactRecordsSection { get; set; }

    [XmlElement("CanadianPhoneSection")]
    public CanadianPhoneSection CanadianPhoneSection { get; set; }

    [XmlElement("CorporateSection")]
    public PersonReportCorporateSection CorporateSection { get; set; }

    [XmlElement("CriminalSection")]
    public PersonReportCriminalSection CriminalSection { get; set; }

    [XmlElement("DeathSection")]
    public DeathSection DeathSection { get; set; }

    [XmlElement("DivorceSection")]
    public DivorceSection DivorceSection { get; set; }

    [XmlElement("DocketSection")]
    public PersonReportDocketSection DocketSection { get; set; }

    [XmlElement("DriverLicenseSection")]
    public DriverLicenseSection DriverLicenseSection { get; set; }

    [XmlElement("DriversAtSubjectAddressSection")]
    public DriversAtSubjectAddressSection DriversAtSubjectAddressSection { get; set; }

    [XmlElement("DunBradstreetSection")]
    public PersonReportDunBradstreetSection DunBradstreetSection { get; set; }

    [XmlElement("EmailSection")]
    public EmailSection EmailSection { get; set; }

    [XmlElement("ExcludedPartySection")]
    public PersonReportExcludedPartySection ExcludedPartySection { get; set; }

    [XmlElement("ExecutiveAffiliationSection")]
    public PersonReportExecutiveAffiliationSection ExecutiveAffiliationSection { get; set; }

    [XmlElement("FcraSection")]
    public FcraSection FcraSection { get; set; }

    [XmlElement("GlobalSanctionSection")]
    public PersonReportGlobalSanctionSection GlobalSanctionSection { get; set; }

    [XmlElement("HealthcareLicenseSection")]
    public HealthcareLicenseSection HealthcareLicenseSection { get; set; }

    [XmlElement("HealthcareSanctionSection")]
    public PersonReportHealthcareSanctionSection HealthcareSanctionSection { get; set; }

    [XmlElement("InfractionSection")]
    public PersonReportInfractionSection InfractionSection { get; set; }

    [XmlElement("LawsuitSection")]
    public PersonReportLawsuitSection LawsuitSection { get; set; }

    [XmlElement("LicenseSection")]
    public LicenseSection LicenseSection { get; set; }

    [XmlElement("LienJudgmentSection")]
    public PersonReportLienJudgmentSection LienJudgmentSection { get; set; }

    [XmlElement("MarijuanaRelatedBusinessesSection")]
    public PersonReportMarijuanaRelatedBusinessesSection MarijuanaRelatedBusinessesSection { get; set; }

    [XmlElement("MarriageSection")]
    public MarriageSection MarriageSection { get; set; }

    [XmlElement("MilitarySection")]
    public MilitarySection MilitarySection { get; set; }

    [XmlElement("MotorVehicleServiceAndWarrantyRecordsSection")]
    public MotorVehicleServiceAndWarrantyRecordsSection MotorVehicleServiceAndWarrantyRecordsSection { get; set; }

    [XmlElement("NeighborSection")]
    public NeighborSection NeighborSection { get; set; }

    [XmlElement("ObituariesNewsSection")]
    public ObituariesNewsSection ObituariesNewsSection { get; set; }

    [XmlElement("OtherNamesforSSNSection")]
    public OtherNamesforSSNSection OtherNamesforSSNSection { get; set; }

    [XmlElement("OtherSSNSection")]
    public OtherSSNSection OtherSSNSection { get; set; }

    [XmlElement("PhoneListingSection")]
    public PhoneListingSection PhoneListingSection { get; set; }

    [XmlElement("PhoneNumberSection")]
    public PersonPhoneNumberSection PhoneNumberSection { get; set; }

    [XmlElement("PoliticalDonorSection")]
    public PoliticalDonorSection PoliticalDonorSection { get; set; }

    [XmlElement("PreForeclosureSection")]
    public PersonPreForeclosureSection PreForeclosureSection { get; set; }

    [XmlElement("ProfessionalLicenseSection")]
    public ProfessionalLicenseSection ProfessionalLicenseSection { get; set; }

    [XmlElement("PropertyOwnerSection")]
    public PropertyOwnerSection PropertyOwnerSection { get; set; }

    [XmlElement("QuickAnalysisFlagSection")]
    public PersonQuickAnalysisFlagSection QuickAnalysisFlagSection { get; set; }

    [XmlElement("RealPropertySection")]
    public PersonRealPropertySection RealPropertySection { get; set; }

    [XmlElement("RealTimeArrestSection")]
    public PersonRealTimeArrestSection RealTimeArrestSection { get; set; }

    [XmlElement("RealTimeVehicleSection")]
    public RealTimeVehicleSection RealTimeVehicleSection { get; set; }

    [XmlElement("RelativeSection")]
    public RelativeSection RelativeSection { get; set; }

    [XmlElement("ShareholderSection")]
    public ShareholderSection ShareholderSection { get; set; }

    [XmlElement("SubjectSection")]
    public SubjectSection SubjectSection { get; set; }

    [XmlElement("UnclaimedAssetSection")]
    public UnclaimedAssetSection UnclaimedAssetSection { get; set; }

    [XmlElement("UserTermsSection")]
    public PersonUserTermsSection UserTermsSection { get; set; }

    [XmlElement("UtilitySection")]
    public UtilitySection UtilitySection { get; set; }

    [XmlElement("VehiclesAtSubjectAddressSection")]
    public VehiclesAtSubjectAddressSection VehiclesAtSubjectAddressSection { get; set; }

    [XmlElement("VehicleSection")]
    public PersonVehicleSection VehicleSection { get; set; }

    [XmlElement("VoterRegistrationSection")]
    public VoterRegistrationSection VoterRegistrationSection { get; set; }

    [XmlElement("WatercraftSection")]
    public PersonWatercraftSection WatercraftSection { get; set; }

    [XmlElement("WebAnalyticsSection")]
    public PersonWebAnalyticsSection WebAnalyticsSection { get; set; }

    [XmlElement("WorkAffiliationSection")]
    public WorkAffiliationSection WorkAffiliationSection { get; set; }

    [XmlElement("WorldCheckSection")]
    public PersonWorldCheckSection WorldCheckSection { get; set; }

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

    [XmlElement("SSNAddressFraudSection")]
    public SSNAddressFraudSection SSNAddressFraudSection { get; set; }

    [XmlElement("NPISection")]
    public PersonNPISection NPISection { get; set; }

    [XmlElement("UCCSection")]
    public PersonUCCSection UCCSection { get; set; }

}
}