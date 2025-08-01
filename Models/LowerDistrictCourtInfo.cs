using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("LowerDistrictCourtInfo")]
public class LowerDistrictCourtInfo
{
    [XmlElement("CaseComplexity")]
    public ValueAndLabelSet CaseComplexity { get; set; }

    [XmlElement("CaseFilingLocation")]
    public CommonDataAddress CaseFilingLocation { get; set; }

    [XmlElement("CaseNote")]
    public ValueAndLabelSet CaseNote { get; set; }

    [XmlElement("CourtInfo")]
    public CourtDataCourtInfo CourtInfo { get; set; }

    [XmlElement("CourtOfAppealsDate")]
    public string CourtOfAppealsDate { get; set; }

    [XmlElement("CourtReporter")]
    public List<string> CourtReporter { get; set; }

    [XmlElement("DateJudgementOrdered")]
    public string DateJudgementOrdered { get; set; }

    [XmlElement("DistrictCourtDocket")]
    public DistrictCourtDocket DistrictCourtDocket { get; set; }

    [XmlElement("DistrictNumber")]
    public string DistrictNumber { get; set; }

    [XmlElement("JudgeOrAuthorizer")]
    public List<string> JudgeOrAuthorizer { get; set; }

    [XmlElement("NoticeOfAssignmentDate")]
    public string NoticeOfAssignmentDate { get; set; }

    [XmlElement("TrialJudges")]
    public List<string> TrialJudges { get; set; }

    [XmlElement("CaseDisposition")]
    public List<CaseDisposition> CaseDisposition { get; set; }

    [XmlElement("CaseDocketID")]
    public string CaseDocketID { get; set; }

    [XmlElement("CaseFiling")]
    public CourtDataCaseFiling CaseFiling { get; set; }

    [XmlElement("CaseSubCategory")]
    public string CaseSubCategory { get; set; }

    [XmlElement("CaseTitle")]
    public string CaseTitle { get; set; }

    [XmlElement("Jurisdiction")]
    public string Jurisdiction { get; set; }
}
