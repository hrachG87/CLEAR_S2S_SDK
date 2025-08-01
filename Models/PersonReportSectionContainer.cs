using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportSectionContainer")]
public class PersonReportSectionContainer
{
    [XmlElement("AddressSection")]
    public bool AddressSection { get; set; }

    [XmlElement("DeathSection")]
    public bool DeathSection { get; set; }

    [XmlElement("WorkAffiliationSection")]
    public bool WorkAffiliationSection { get; set; }

    [XmlElement("UtilitySection")]
    public bool UtilitySection { get; set; }

    [XmlElement("OtherSSNSection")]
    public bool OtherSSNSection { get; set; }

    [XmlElement("OtherNamesforSSNSection")]
    public bool OtherNamesforSSNSection { get; set; }

    [XmlElement("PhoneNumberSection")]
    public bool PhoneNumberSection { get; set; }

    [XmlElement("PhoneListingSection")]
    public bool PhoneListingSection { get; set; }

    [XmlElement("CanadianPhoneSection")]
    public bool CanadianPhoneSection { get; set; }

    [XmlElement("EmailSection")]
    public bool EmailSection { get; set; }

    [XmlElement("DriverLicenseSection")]
    public bool DriverLicenseSection { get; set; }

    [XmlElement("MarriageSection")]
    public bool MarriageSection { get; set; }

    [XmlElement("DivorceSection")]
    public bool DivorceSection { get; set; }

    [XmlElement("LicenseSection")]
    public bool LicenseSection { get; set; }

    [XmlElement("HealthcareLicenseSection")]
    public bool HealthcareLicenseSection { get; set; }

    [XmlElement("MilitarySection")]
    public bool MilitarySection { get; set; }

    [XmlElement("PoliticalDonorSection")]
    public bool PoliticalDonorSection { get; set; }

    [XmlElement("VoterRegistrationSection")]
    public bool VoterRegistrationSection { get; set; }

    [XmlElement("DriversAtSubjectAddressSection")]
    public bool DriversAtSubjectAddressSection { get; set; }

    [XmlElement("GlobalSanctionSection")]
    public bool GlobalSanctionSection { get; set; }

    [XmlElement("HealthcareSanctionSection")]
    public bool HealthcareSanctionSection { get; set; }

    [XmlElement("ExcludedPartySection")]
    public bool ExcludedPartySection { get; set; }

    [XmlElement("WorldCheckSection")]
    public bool WorldCheckSection { get; set; }

    [XmlElement("InfractionSection")]
    public bool InfractionSection { get; set; }

    [XmlElement("CriminalSection")]
    public bool CriminalSection { get; set; }

    [XmlElement("RealTimeArrestSection")]
    public bool RealTimeArrestSection { get; set; }

    [XmlElement("ArrestSection")]
    public bool ArrestSection { get; set; }

    [XmlElement("ExecutiveAffiliationSection")]
    public bool ExecutiveAffiliationSection { get; set; }

    [XmlElement("DunBradstreetSection")]
    public bool DunBradstreetSection { get; set; }

    [XmlElement("ShareholderSection")]
    public bool ShareholderSection { get; set; }

    [XmlElement("BusinessAtSubjectAddressSection")]
    public bool BusinessAtSubjectAddressSection { get; set; }

    [XmlElement("LienJudgmentSection")]
    public bool LienJudgmentSection { get; set; }

    [XmlElement("BankruptcySection")]
    public bool BankruptcySection { get; set; }

    [XmlElement("LawsuitSection")]
    public bool LawsuitSection { get; set; }

    [XmlElement("DocketSection")]
    public bool DocketSection { get; set; }

    [XmlElement("CorporateSection")]
    public bool CorporateSection { get; set; }

    [XmlElement("RealPropertySection")]
    public bool RealPropertySection { get; set; }

    [XmlElement("PropertyOwnerSection")]
    public bool PropertyOwnerSection { get; set; }

    [XmlElement("PreForeclosureSection")]
    public bool PreForeclosureSection { get; set; }

    [XmlElement("RealTimeVehicleSection")]
    public bool RealTimeVehicleSection { get; set; }

    [XmlElement("VehicleSection")]
    public bool VehicleSection { get; set; }

    [XmlElement("VehiclesAtSubjectAddressSection")]
    public bool VehiclesAtSubjectAddressSection { get; set; }

    [XmlElement("WatercraftSection")]
    public bool WatercraftSection { get; set; }

    [XmlElement("AircraftSection")]
    public bool AircraftSection { get; set; }

    [XmlElement("UnclaimedAssetSection")]
    public bool UnclaimedAssetSection { get; set; }

    [XmlElement("RelativeSection")]
    public bool RelativeSection { get; set; }

    [XmlElement("AssociateSection")]
    public bool AssociateSection { get; set; }

    [XmlElement("NeighborSection")]
    public bool NeighborSection { get; set; }

    [XmlElement("QuickAnalysisFlagSection")]
    public bool QuickAnalysisFlagSection { get; set; }

    [XmlElement("AssociateAnalyticsChartSection")]
    public bool AssociateAnalyticsChartSection { get; set; }

    [XmlElement("ObituariesNewsSection")]
    public bool ObituariesNewsSection { get; set; }

    [XmlElement("WebAnalyticsSection")]
    public bool WebAnalyticsSection { get; set; }

    [XmlElement("MotorVehicleServiceAndWarrantyRecordsSection")]
    public bool MotorVehicleServiceAndWarrantyRecordsSection { get; set; }

    [XmlElement("MarijuanaRelatedBusinessesSection")]
    public bool MarijuanaRelatedBusinessesSection { get; set; }

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

    [XmlElement("BusinessContactRecordsSection")]
    public bool BusinessContactRecordsSection { get; set; }

    [XmlElement("NoMatchSections")]
    public bool NoMatchSections { get; set; }

    [XmlElement("SSNAddressFraudSection")]
    public bool SSNAddressFraudSection { get; set; }

    [XmlElement("UCCSection")]
    public bool UCCSection { get; set; }

    [XmlElement("NPISection")]
    public bool NPISection { get; set; }

}
}