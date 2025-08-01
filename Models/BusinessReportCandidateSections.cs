using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessReportCandidateSections")]
public class BusinessReportCandidateSections
{
    [XmlElement("AircraftSection")]
    public bool AircraftSection { get; set; }

    [XmlElement("AnnualFinancialsSection")]
    public bool AnnualFinancialsSection { get; set; }

    [XmlElement("ArrestSection")]
    public bool ArrestSection { get; set; }

    [XmlElement("AssociateAnalyticsChartSection")]
    public bool AssociateAnalyticsChartSection { get; set; }

    [XmlElement("BankruptcySection")]
    public bool BankruptcySection { get; set; }

    [XmlElement("BusinessContactSection")]
    public bool BusinessContactSection { get; set; }

    [XmlElement("BusinessFinderSection")]
    public bool BusinessFinderSection { get; set; }

    [XmlElement("BusinessOverviewSection")]
    public bool BusinessOverviewSection { get; set; }

    [XmlElement("BusinessProfileSection")]
    public bool BusinessProfileSection { get; set; }

    [XmlElement("BusinessSameAddressSection")]
    public bool BusinessSameAddressSection { get; set; }

    [XmlElement("BusinessSamePhoneSection")]
    public bool BusinessSamePhoneSection { get; set; }

    [XmlElement("CompanyProfileSection")]
    public bool CompanyProfileSection { get; set; }

    [XmlElement("CorporateSection")]
    public bool CorporateSection { get; set; }

    [XmlElement("CriminalSection")]
    public bool CriminalSection { get; set; }

    [XmlElement("DocketSection")]
    public bool DocketSection { get; set; }

    [XmlElement("DunBradstreePCISection")]
    public bool DunBradstreePCISection { get; set; }

    [XmlElement("DunBradstreetSection")]
    public bool DunBradstreetSection { get; set; }

    [XmlElement("ExcludedPartySection")]
    public bool ExcludedPartySection { get; set; }

    [XmlElement("ExecutiveAffiliationSection")]
    public bool ExecutiveAffiliationSection { get; set; }

    [XmlElement("BusinessContactRecordsSection")]
    public bool BusinessContactRecordsSection { get; set; }

    [XmlElement("ExecutiveOfficersSection")]
    public bool ExecutiveOfficersSection { get; set; }

    [XmlElement("ExecutiveProfileSection")]
    public bool ExecutiveProfileSection { get; set; }

    [XmlElement("FederalCaseLawSection")]
    public bool FederalCaseLawSection { get; set; }

    [XmlElement("FictitiousBusinessNameSection")]
    public bool FictitiousBusinessNameSection { get; set; }

    [XmlElement("FundamentalRatiosSection")]
    public bool FundamentalRatiosSection { get; set; }

    [XmlElement("GlobalSanctionSection")]
    public bool GlobalSanctionSection { get; set; }

    [XmlElement("HealthcareSanctionSection")]
    public bool HealthcareSanctionSection { get; set; }

    [XmlElement("InfractionSection")]
    public bool InfractionSection { get; set; }

    [XmlElement("LawsuitSection")]
    public bool LawsuitSection { get; set; }

    [XmlElement("LienJudgmentSection")]
    public bool LienJudgmentSection { get; set; }

    [XmlElement("MarijuanaRelatedBusinessesSection")]
    public bool MarijuanaRelatedBusinessesSection { get; set; }

    [XmlElement("MoneyServiceBusinessSection")]
    public bool MoneyServiceBusinessSection { get; set; }

    [XmlElement("NewsSection")]
    public bool NewsSection { get; set; }

    [XmlElement("NoMatchSections")]
    public bool NoMatchSections { get; set; }

    [XmlElement("OtherSecurityFilingRecordSection")]
    public bool OtherSecurityFilingRecordSection { get; set; }

    [XmlElement("PeopleSameAddressSection")]
    public bool PeopleSameAddressSection { get; set; }

    [XmlElement("PeopleSamePhoneSection")]
    public bool PeopleSamePhoneSection { get; set; }

    [XmlElement("PhoneNumberSection")]
    public bool PhoneNumberSection { get; set; }

    [XmlElement("PreForeclosureSection")]
    public bool PreForeclosureSection { get; set; }

    [XmlElement("ProfessionalLicenseSection")]
    public bool ProfessionalLicenseSection { get; set; }

    [XmlElement("QuickAnalysisFlagSection")]
    public bool QuickAnalysisFlagSection { get; set; }

    [XmlElement("RealPropertySection")]
    public bool RealPropertySection { get; set; }

    [XmlElement("RelatedSECFilingRecordSection")]
    public bool RelatedSECFilingRecordSection { get; set; }

    [XmlElement("StateCaseLawSection")]
    public bool StateCaseLawSection { get; set; }

    [XmlElement("UserTermsSection")]
    public bool UserTermsSection { get; set; }

    [XmlElement("VehicleSection")]
    public bool VehicleSection { get; set; }

    [XmlElement("WatercraftSection")]
    public bool WatercraftSection { get; set; }

    [XmlElement("WebAnalyticsSection")]
    public bool WebAnalyticsSection { get; set; }

    [XmlElement("WorldbaseSection")]
    public bool WorldbaseSection { get; set; }

    [XmlElement("WorldCheckSection")]
    public bool WorldCheckSection { get; set; }

    [XmlElement("FEINSection")]
    public bool FEINSection { get; set; }

    [XmlElement("SECFilingSection")]
    public bool SECFilingSection { get; set; }

    [XmlElement("UCCSection")]
    public bool UCCSection { get; set; }

    [XmlElement("NPISection")]
    public bool NPISection { get; set; }

}
}