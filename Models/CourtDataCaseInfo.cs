using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtDataCaseInfo")]
public class CourtDataCaseInfo
{
    [XmlElement("AppealFrom")]
    public string AppealFrom { get; set; }

    [XmlElement("CaseComplexity")]
    public ValueAndLabelSet CaseComplexity { get; set; }

    [XmlElement("CaseDescription")]
    public ValueAndLabelSet CaseDescription { get; set; }

    [XmlElement("CaseFilingLocation")]
    public CommonDataAddress CaseFilingLocation { get; set; }

    [XmlElement("CaseNote")]
    public List<ValueAndLabelSet> CaseNote { get; set; }

    [XmlElement("CaseStatusAndDate")]
    public List<ValueAndLabelSet> CaseStatusAndDate { get; set; }

    [XmlElement("CaseUpdateDate")]
    public string CaseUpdateDate { get; set; }

    [XmlElement("ClassActionFlag")]
    public string ClassActionFlag { get; set; }

    [XmlElement("Consolidated")]
    public ValueAndLabelSet Consolidated { get; set; }

    [XmlElement("CourtInfo")]
    public CourtDataCourtInfo CourtInfo { get; set; }

    [XmlElement("DateAssigned")]
    public ValueAndLabelSet DateAssigned { get; set; }

    [XmlElement("Department")]
    public ValueAndLabelSet Department { get; set; }

    [XmlElement("DistrictCourtDocket")]
    public DistrictCourtDocket DistrictCourtDocket { get; set; }

    [XmlElement("Division")]
    public string Division { get; set; }

    [XmlElement("DocketCloseDate")]
    public ValueAndLabelSet DocketCloseDate { get; set; }

    [XmlElement("DocketNotes")]
    public List<ValueAndLabelSet> DocketNotes { get; set; }

    [XmlElement("FeeStatus")]
    public string FeeStatus { get; set; }

    [XmlElement("JudgeOrAuthorizer")]
    public List<string> JudgeOrAuthorizer { get; set; }

    [XmlElement("JudgeTermDates")]
    public List<string> JudgeTermDates { get; set; }

    [XmlElement("KeyNatureOfSuitInfo")]
    public List<KeyNatureOfSuitInfo> KeyNatureOfSuitInfo { get; set; }

    [XmlElement("NatureOfSuitInfo")]
    public List<NatureOfSuitInfo> NatureOfSuitInfo { get; set; }

    [XmlElement("OtherDocketNumber")]
    public List<ValueAndLabelSet> OtherDocketNumber { get; set; }

    [XmlElement("PreTrialDate")]
    public ValueAndLabelSet PreTrialDate { get; set; }

    [XmlElement("RelatedCaseNumber")]
    public List<ValueAndLabelSet> RelatedCaseNumber { get; set; }

    [XmlElement("TrialTypeAndDate")]
    public ValueAndLabelSet TrialTypeAndDate { get; set; }

    [XmlElement("CaseCategory")]
    public List<string> CaseCategory { get; set; }

    [XmlElement("CaseDisposition")]
    public List<CaseDisposition> CaseDisposition { get; set; }

    [XmlElement("CaseDocketID")]
    public string CaseDocketID { get; set; }

    [XmlElement("CaseFiling")]
    public CourtDataCaseFiling CaseFiling { get; set; }

    [XmlElement("CaseSubCategory")]
    public List<string> CaseSubCategory { get; set; }

    [XmlElement("CaseTitle")]
    public List<string> CaseTitle { get; set; }

    [XmlElement("Jurisdiction")]
    public string Jurisdiction { get; set; }

    [XmlElement("FilingState")]
    public string FilingState { get; set; }

    [XmlElement("CaseType")]
    public string CaseType { get; set; }

}
}