using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyReportSectionDetails")]
public class CompanyReportSectionDetails
{
    [XmlElement("AircraftSection")]
    public CompanyReportAircraftSection AircraftSection { get; set; }

    [XmlElement("AnnualFinancialsSection")]
    public AnnualFinancialsSection AnnualFinancialsSection { get; set; }

    [XmlElement("ArrestSection")]
    public CompanyReportArrestSection ArrestSection { get; set; }

    [XmlElement("AssociateAnalyticsChartSection")]
    public CompanyReportAssociateAnalyticsChartSection AssociateAnalyticsChartSection { get; set; }

    [XmlElement("BankruptcySection")]
    public CompanyReportBankruptcySection BankruptcySection { get; set; }

    [XmlElement("BusinessContactSection")]
    public BusinessContactSection BusinessContactSection { get; set; }

    [XmlElement("BusinessFinderSection")]
    public BusinessFinderSection BusinessFinderSection { get; set; }

    [XmlElement("BusinessOverviewSection")]
    public BusinessOverviewSection BusinessOverviewSection { get; set; }

    [XmlElement("BusinessProfileSection")]
    public BusinessProfileSection BusinessProfileSection { get; set; }

    [XmlElement("BusinessSameAddressSection")]
    public BusinessSameAddressSection BusinessSameAddressSection { get; set; }

    [XmlElement("BusinessSamePhoneSection")]
    public BusinessSamePhoneSection BusinessSamePhoneSection { get; set; }

    [XmlElement("CompanyProfileSection")]
    public CompanyProfileSection CompanyProfileSection { get; set; }

    [XmlElement("CorporateSection")]
    public CompanyReportCorporateSection CorporateSection { get; set; }

    [XmlElement("CriminalSection")]
    public CompanyReportCriminalSection CriminalSection { get; set; }

    [XmlElement("DocketSection")]
    public CompanyReportDocketSection DocketSection { get; set; }

    [XmlElement("DunBradstreetPCISection")]
    public DunBradstreetPCISection DunBradstreetPCISection { get; set; }

    [XmlElement("DunBradstreetSection")]
    public CompanyReportDunBradstreetSection DunBradstreetSection { get; set; }

    [XmlElement("ExcludedPartySection")]
    public CompanyReportExcludedPartySection ExcludedPartySection { get; set; }

    [XmlElement("ExecutiveAffiliationSection")]
    public CompanyReportExecutiveAffiliationSection ExecutiveAffiliationSection { get; set; }

    [XmlElement("BusinessContactRecordsSection")]
    public BusinessContactRecordsSection BusinessContactRecordsSection { get; set; }

    [XmlElement("ExecutiveOfficersSection")]
    public ExecutiveOfficersSection ExecutiveOfficersSection { get; set; }

    [XmlElement("ExecutiveProfileSection")]
    public ExecutiveProfileSection ExecutiveProfileSection { get; set; }

    [XmlElement("FederalCaseLawSection")]
    public FederalCaseLawSection FederalCaseLawSection { get; set; }

    [XmlElement("FictitiousBusinessNameSection")]
    public FictitiousBusinessNameSection FictitiousBusinessNameSection { get; set; }

    [XmlElement("FundamentalRatiosSection")]
    public FundamentalRatiosSection FundamentalRatiosSection { get; set; }

    [XmlElement("GlobalSanctionSection")]
    public CompanyReportGlobalSanctionSection GlobalSanctionSection { get; set; }

    [XmlElement("HealthcareSanctionSection")]
    public CompanyReportHealthcareSanctionSection HealthcareSanctionSection { get; set; }

    [XmlElement("InfractionSection")]
    public CompanyReportInfractionSection InfractionSection { get; set; }

    [XmlElement("LawsuitSection")]
    public CompanyReportLawsuitSection LawsuitSection { get; set; }

    [XmlElement("LienJudgmentSection")]
    public CompanyReportLienJudgmentSection LienJudgmentSection { get; set; }

    [XmlElement("MarijuanaRelatedBusinessesSection")]
    public CompanyReportMarijuanaRelatedBusinessesSection MarijuanaRelatedBusinessesSection { get; set; }

    [XmlElement("MoneyServiceBusinessSection")]
    public MoneyServiceBusinessSection MoneyServiceBusinessSection { get; set; }

    [XmlElement("NewsSection")]
    public NewsSection NewsSection { get; set; }

    [XmlElement("OtherSecurityFilingRecordSection")]
    public OtherSecurityFilingRecordSection OtherSecurityFilingRecordSection { get; set; }

    [XmlElement("PeopleSameAddressSection")]
    public PeopleSameAddressSection PeopleSameAddressSection { get; set; }

    [XmlElement("PeopleSamePhoneSection")]
    public PeopleSamePhoneSection PeopleSamePhoneSection { get; set; }

    [XmlElement("PhoneNumberSection")]
    public CompanyPhoneNumberSection PhoneNumberSection { get; set; }

    [XmlElement("PreForeclosureSection")]
    public CompanyPreForeclosureSection PreForeclosureSection { get; set; }

    [XmlElement("ProfessionalLicenseSection")]
    public ProfessionalLicenseSection ProfessionalLicenseSection { get; set; }

    [XmlElement("QuickAnalysisFlagSection")]
    public CompanyQuickAnalysisFlagSection QuickAnalysisFlagSection { get; set; }

    [XmlElement("RealPropertySection")]
    public CompanyRealPropertySection RealPropertySection { get; set; }

    [XmlElement("RelatedSECFilingRecordSection")]
    public RelatedSECFilingRecordSection RelatedSECFilingRecordSection { get; set; }

    [XmlElement("StateCaseLawSection")]
    public StateCaseLawSection StateCaseLawSection { get; set; }

    [XmlElement("UserTermsSection")]
    public CompanyUserTermsSection UserTermsSection { get; set; }

    [XmlElement("VehicleSection")]
    public CompanyVehicleSection VehicleSection { get; set; }

    [XmlElement("WatercraftSection")]
    public CompanyWatercraftSection WatercraftSection { get; set; }

    [XmlElement("WebAnalyticsSection")]
    public CompanyWebAnalyticsSection WebAnalyticsSection { get; set; }

    [XmlElement("WorldCheckSection")]
    public CompanyWorldCheckSection WorldCheckSection { get; set; }

    [XmlElement("WorldbaseSection")]
    public WorldbaseSection WorldbaseSection { get; set; }

    [XmlElement("GlobalBeneficialOwnershipSubjectSection")]
    public GlobalBeneficialOwnershipSubjectSection GlobalBeneficialOwnershipSubjectSection { get; set; }

    [XmlElement("GlobalBeneficialOwnershipSummarySection")]
    public GlobalBeneficialOwnershipSummarySection GlobalBeneficialOwnershipSummarySection { get; set; }

    [XmlElement("GlobalBeneficialOwnershipDetailsSection")]
    public GlobalBeneficialOwnershipDetailsSection GlobalBeneficialOwnershipDetailsSection { get; set; }

    [XmlElement("GlobalBeneficialOwnershipSourceDocumentsSection")]
    public GlobalBeneficialOwnershipSourceDocumentsSection GlobalBeneficialOwnershipSourceDocumentsSection { get; set; }

    [XmlElement("NoMatchSections")]
    public NoMatchSections NoMatchSections { get; set; }

    [XmlElement("NPISection")]
    public CompanyNPISection NPISection { get; set; }

    [XmlElement("SECFilingSection")]
    public SECFilingSection SECFilingSection { get; set; }

    [XmlElement("UCCSection")]
    public CompanyUCCSection UCCSection { get; set; }

    [XmlElement("FEINSection")]
    public FEINSection FEINSection { get; set; }
}
