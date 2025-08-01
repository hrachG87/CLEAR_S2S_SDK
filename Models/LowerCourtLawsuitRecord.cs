using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LowerCourtLawsuitRecord")]
public class LowerCourtLawsuitRecord
{
    [XmlElement("AppointedDate")]
    public string AppointedDate { get; set; }

    [XmlElement("AwardFiledDate")]
    public string AwardFiledDate { get; set; }

    [XmlElement("CalendarInfo")]
    public List<CalendarInfo> CalendarInfo { get; set; }

    [XmlElement("CaseAwardsInfo")]
    public List<CaseAwardsInfo> CaseAwardsInfo { get; set; }

    [XmlElement("CaseCategory")]
    public List<string> CaseCategory { get; set; }

    [XmlElement("CaseComments")]
    public string CaseComments { get; set; }

    [XmlElement("CaseDemand")]
    public string CaseDemand { get; set; }

    [XmlElement("CaseDescription")]
    public string CaseDescription { get; set; }

    [XmlElement("CaseRemedyInfo")]
    public List<CaseRemedyInfo> CaseRemedyInfo { get; set; }

    [XmlElement("CertifiedDate")]
    public string CertifiedDate { get; set; }

    [XmlElement("CommentInfo")]
    public List<CommentInfo> CommentInfo { get; set; }

    [XmlElement("Court")]
    public string Court { get; set; }

    [XmlElement("CourtLocation")]
    public string CourtLocation { get; set; }

    [XmlElement("DesignationDate")]
    public string DesignationDate { get; set; }

    [XmlElement("DispositionInfo")]
    public CaseDisposition DispositionInfo { get; set; }

    [XmlElement("EstateStatus")]
    public string EstateStatus { get; set; }

    [XmlElement("FilingInfo")]
    public CourtDataFilingInfo FilingInfo { get; set; }

    [XmlElement("FilmNumber")]
    public string FilmNumber { get; set; }

    [XmlElement("JudgeName")]
    public string JudgeName { get; set; }

    [XmlElement("LowerCourtInfo")]
    public List<LowerCourtInfo> LowerCourtInfo { get; set; }

    [XmlElement("PhoneInfo")]
    public PhoneInfo PhoneInfo { get; set; }

    [XmlElement("PropertyInfo")]
    public string PropertyInfo { get; set; }

    [XmlElement("TrialDate")]
    public string TrialDate { get; set; }

    [XmlElement("TrialLength")]
    public string TrialLength { get; set; }

    [XmlElement("TypeofTrial")]
    public string TypeofTrial { get; set; }

    [XmlElement("VenueLocation")]
    public string VenueLocation { get; set; }

    [XmlElement("CaseType")]
    public List<string> CaseType { get; set; }

    [XmlElement("CaseTitle")]
    public List<string> CaseTitle { get; set; }

    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("StatusDate")]
    public string StatusDate { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}
}