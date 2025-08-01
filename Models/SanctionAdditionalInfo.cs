using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SanctionAdditionalInfo")]
public class SanctionAdditionalInfo
{
    [XmlElement("AcceptsResponsibility")]
    public string AcceptsResponsibility { get; set; }

    [XmlElement("Active")]
    public string Active { get; set; }

    [XmlElement("ActiveDate")]
    public string ActiveDate { get; set; }

    [XmlElement("AdditionalInformation")]
    public string AdditionalInformation { get; set; }

    [XmlElement("AdditionalComments")]
    public string AdditionalComments { get; set; }

    [XmlElement("AdditionalInfo")]
    public string AdditionalInfo { get; set; }

    [XmlElement("AdditionalRegulatoryFineOrPayment")]
    public string AdditionalRegulatoryFineOrPayment { get; set; }

    [XmlElement("Address")]
    public string Address { get; set; }

    [XmlElement("AddressOriginalLanguage")]
    public string AddressOriginalLanguage { get; set; }

    [XmlElement("AddressCountry")]
    public string AddressCountry { get; set; }

    [XmlElement("Affiliation")]
    public string Affiliation { get; set; }

    [XmlElement("AgreementLength")]
    public string AgreementLength { get; set; }

    [XmlElement("AgreementRequiredNewPositions")]
    public string AgreementRequiredNewPositions { get; set; }

    [XmlElement("AgreementRequiredOutsideAuditorsOrExperts")]
    public string AgreementRequiredOutsideAuditorsOrExperts { get; set; }

    [XmlElement("AkaWeak")]
    public string AkaWeak { get; set; }

    [XmlElement("Alias")]
    public string Alias { get; set; }

    [XmlElement("AliasOriginalLanguage")]
    public string AliasOriginalLanguage { get; set; }

    [XmlElement("Authority")]
    public string Authority { get; set; }

    [XmlElement("BirthDate")]
    public string BirthDate { get; set; }

    [XmlElement("BirthPlace")]
    public string BirthPlace { get; set; }

    [XmlElement("BusinessOwner")]
    public string BusinessOwner { get; set; }

    [XmlElement("CaseHeader")]
    public string CaseHeader { get; set; }

    [XmlElement("CaseId")]
    public string CaseId { get; set; }

    [XmlElement("CaseName")]
    public string CaseName { get; set; }

    [XmlElement("Category")]
    public string Category { get; set; }

    [XmlElement("CitationAndDesc")]
    public string CitationAndDesc { get; set; }

    [XmlElement("Citizenship")]
    public string Citizenship { get; set; }

    [XmlElement("Committees")]
    public string Committees { get; set; }

    [XmlElement("CommunityServiceOrOther")]
    public string CommunityServiceOrOther { get; set; }

    [XmlElement("ComplianceProgramDesc")]
    public string ComplianceProgramDesc { get; set; }

    [XmlElement("ComplianceProgramRequiredByAgreement")]
    public string ComplianceProgramRequiredByAgreement { get; set; }

    [XmlElement("ComplianceProgramRequiredByAgreementDesc")]
    public string ComplianceProgramRequiredByAgreementDesc { get; set; }

    [XmlElement("ComplianceRequiredByRegulators")]
    public string ComplianceRequiredByRegulators { get; set; }

    [XmlElement("Countries")]
    public string Countries { get; set; }

    [XmlElement("Country")]
    public string Country { get; set; }

    [XmlElement("CountryCap")]
    public string CountryCap { get; set; }

    [XmlElement("County")]
    public string County { get; set; }

    [XmlElement("CountryOfOrigin")]
    public string CountryOfOrigin { get; set; }

    [XmlElement("Crd")]
    public string Crd { get; set; }

    [XmlElement("CrossReference")]
    public string CrossReference { get; set; }

    [XmlElement("CtCode")]
    public string CtCode { get; set; }

    [XmlElement("Date")]
    public string Date { get; set; }

    [XmlElement("DateOfBirth")]
    public string DateOfBirth { get; set; }

    [XmlElement("DateOfIncorporation")]
    public string DateOfIncorporation { get; set; }

    [XmlElement("DateOfIncorporationOfTheList")]
    public string DateOfIncorporationOfTheList { get; set; }

    [XmlElement("DateOfInformation")]
    public string DateOfInformation { get; set; }

    [XmlElement("DateOfPublication")]
    public string DateOfPublication { get; set; }

    [XmlElement("DateOfRegistration")]
    public string DateOfRegistration { get; set; }

    [XmlElement("DebarFromDate")]
    public string DebarFromDate { get; set; }

    [XmlElement("DebarReason")]
    public string DebarReason { get; set; }

    [XmlElement("DebarToDate")]
    public string DebarToDate { get; set; }

    [XmlElement("DescriptionOfPayments")]
    public string DescriptionOfPayments { get; set; }

    [XmlElement("DispositionType")]
    public string DispositionType { get; set; }

    [XmlElement("Document")]
    public string Document { get; set; }

    [XmlElement("DojCanUnilaterallyTerminate")]
    public string DojCanUnilaterallyTerminate { get; set; }

    [XmlElement("Email")]
    public string Email { get; set; }

    [XmlElement("EmailAddress")]
    public string EmailAddress { get; set; }

    [XmlElement("EntityStatus")]
    public string EntityStatus { get; set; }

    [XmlElement("ExcludingAgency")]
    public string ExcludingAgency { get; set; }

    [XmlElement("ExclusionProgram")]
    public string ExclusionProgram { get; set; }

    [XmlElement("ExclusionType")]
    public string ExclusionType { get; set; }

    [XmlElement("Fax")]
    public string Fax { get; set; }

    [XmlElement("FinancialInstitution")]
    public string FinancialInstitution { get; set; }

    [XmlElement("Fine")]
    public string Fine { get; set; }

    [XmlElement("FineCalculationIncluded")]
    public string FineCalculationIncluded { get; set; }

    [XmlElement("FineDescription")]
    public string FineDescription { get; set; }

    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("ForfeitureDisgorgement")]
    public string ForfeitureDisgorgement { get; set; }

    [XmlElement("Function")]
    public string Function { get; set; }

    [XmlElement("GdcId")]
    public string GdcId { get; set; }

    [XmlElement("GdcSanctionsId")]
    public string GdcSanctionsId { get; set; }

    [XmlElement("Gender")]
    public string Gender { get; set; }

    [XmlElement("Guid")]
    public string Guid { get; set; }

    [XmlElement("Identification")]
    public string Identification { get; set; }

    [XmlElement("IdNumber")]
    public string IdNumber { get; set; }

    [XmlElement("Image")]
    public string Image { get; set; }

    [XmlElement("IndependentMonitorReq")]
    public string IndependentMonitorReq { get; set; }

    [XmlElement("JudgementDate")]
    public string JudgementDate { get; set; }

    [XmlElement("Jurisdiction")]
    public string Jurisdiction { get; set; }

    [XmlElement("Justification")]
    public string Justification { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

    [XmlElement("LegalStructure")]
    public string LegalStructure { get; set; }

    [XmlElement("LicenseExpires")]
    public string LicenseExpires { get; set; }

    [XmlElement("LicenseNumber")]
    public string LicenseNumber { get; set; }

    [XmlElement("LicenseType")]
    public string LicenseType { get; set; }

    [XmlElement("Link")]
    public string Link { get; set; }

    [XmlElement("ListingInfo")]
    public string ListingInfo { get; set; }

    [XmlElement("MonitorLength")]
    public string MonitorLength { get; set; }

    [XmlElement("MedicalGrade")]
    public string MedicalGrade { get; set; }

    [XmlElement("MexicanId")]
    public string MexicanId { get; set; }

    [XmlElement("MoreInfo")]
    public string MoreInfo { get; set; }

    [XmlElement("MustComportWithUSSGOrAuditCompliance")]
    public string MustComportWithUSSGOrAuditCompliance { get; set; }

    [XmlElement("Naics")]
    public string Naics { get; set; }

    [XmlElement("NameOfTheList")]
    public string NameOfTheList { get; set; }

    [XmlElement("Nationality")]
    public string Nationality { get; set; }

    [XmlElement("nationalSanctions")]
    public string nationalSanctions { get; set; }

    [XmlElement("Notes")]
    public string Notes { get; set; }

    [XmlElement("OfsiId")]
    public string OfsiId { get; set; }

    [XmlElement("OtherAgreementRequiredGovernanceChanges")]
    public string OtherAgreementRequiredGovernanceChanges { get; set; }

    [XmlElement("OtherAgreementRequiredGovernanceChangesDesc")]
    public string OtherAgreementRequiredGovernanceChangesDesc { get; set; }

    [XmlElement("OtherComplianceOfficerOrConsultantRequired")]
    public string OtherComplianceOfficerOrConsultantRequired { get; set; }

    [XmlElement("OtherInformation")]
    public string OtherInformation { get; set; }

    [XmlElement("ParallelCivilSuit")]
    public string ParallelCivilSuit { get; set; }

    [XmlElement("ParallelRegulatoryActionOrLocalProsecutor")]
    public string ParallelRegulatoryActionOrLocalProsecutor { get; set; }

    [XmlElement("ParallelRegulatoryActionOrLocalProsecutorDesc")]
    public string ParallelRegulatoryActionOrLocalProsecutorDesc { get; set; }

    [XmlElement("PassportNumber1")]
    public string PassportNumber1 { get; set; }

    [XmlElement("PassportNumber2")]
    public string PassportNumber2 { get; set; }

    [XmlElement("PersonIdDetails")]
    public string PersonIdDetails { get; set; }

    [XmlElement("Phone")]
    public string Phone { get; set; }

    [XmlElement("PlaceOfBirth")]
    public string PlaceOfBirth { get; set; }

    [XmlElement("PleaDate")]
    public string PleaDate { get; set; }

    [XmlElement("Position")]
    public string Position { get; set; }

    [XmlElement("PpNodeId")]
    public string PpNodeId { get; set; }

    [XmlElement("PpOfficerOf")]
    public string PpOfficerOf { get; set; }

    [XmlElement("PrimaryCrimeCode")]
    public string PrimaryCrimeCode { get; set; }

    [XmlElement("PreAgreementCompliance")]
    public string PreAgreementCompliance { get; set; }

    [XmlElement("PreAgreementComplianceDesc")]
    public string PreAgreementComplianceDesc { get; set; }

    [XmlElement("PrivacyWaiverDesc")]
    public string PrivacyWaiverDesc { get; set; }

    [XmlElement("ProbationLength")]
    public string ProbationLength { get; set; }

    [XmlElement("Program")]
    public string Program { get; set; }

    [XmlElement("PublicationDate")]
    public string PublicationDate { get; set; }

    [XmlElement("ReasonsOrRelevantConsiderationsForLeniency")]
    public string ReasonsOrRelevantConsiderationsForLeniency { get; set; }

    [XmlElement("ReasonsOrRelevantConsiderationsForLeniencyDesc")]
    public string ReasonsOrRelevantConsiderationsForLeniencyDesc { get; set; }

    [XmlElement("RegimeName")]
    public string RegimeName { get; set; }

    [XmlElement("RegAgency")]
    public string RegAgency { get; set; }

    [XmlElement("RegimeType")]
    public string RegimeType { get; set; }

    [XmlElement("RegulatoryDisgoregementRestitutionForfeiture")]
    public string RegulatoryDisgoregementRestitutionForfeiture { get; set; }

    [XmlElement("Remark")]
    public string Remark { get; set; }

    [XmlElement("Remarks")]
    public string Remarks { get; set; }

    [XmlElement("Restitution")]
    public string Restitution { get; set; }

    [XmlElement("RetailDelivery")]
    public string RetailDelivery { get; set; }

    [XmlElement("SamNumber")]
    public string SamNumber { get; set; }

    [XmlElement("GboId")]
    public string GboId { get; set; }

    [XmlElement("GboScore")]
    public string GboScore { get; set; }

    [XmlElement("SecoSanction")]
    public string SecoSanction { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("StatementOfFacts")]
    public string StatementOfFacts { get; set; }

    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("Summary")]
    public string Summary { get; set; }

    [XmlElement("SwissBankProgram")]
    public string SwissBankProgram { get; set; }

    [XmlElement("TerminationDate")]
    public string TerminationDate { get; set; }

    [XmlElement("Ticker")]
    public string Ticker { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("UboInfo")]
    public string UboInfo { get; set; }

    [XmlElement("UnrelatedTerms")]
    public string UnrelatedTerms { get; set; }

    [XmlElement("TotalPayment")]
    public string TotalPayment { get; set; }

    [XmlElement("TotalRegulatory")]
    public string TotalRegulatory { get; set; }

    [XmlElement("UkStatementOfReasons")]
    public string UkStatementOfReasons { get; set; }

    [XmlElement("Url")]
    public string Url { get; set; }

    [XmlElement("UsPublicCo")]
    public string UsPublicCo { get; set; }

    [XmlElement("Website")]
    public string Website { get; set; }

}
}