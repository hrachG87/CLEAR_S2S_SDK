using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalDataCourtInfo")]
public class CriminalDataCourtInfo
{
    [XmlElement("Address")]
    public List<CommonDataAddress> Address { get; set; }

    [XmlElement("ArraignmentDate")]
    public string ArraignmentDate { get; set; }

    [XmlElement("CriminalDataCaseInfo")]
    public CriminalDataCaseInfo CriminalDataCaseInfo { get; set; }

    [XmlElement("CaseTypeAmended")]
    public string CaseTypeAmended { get; set; }

    [XmlElement("CourtDivision")]
    public string CourtDivision { get; set; }

    [XmlElement("CourtName")]
    public string CourtName { get; set; }

    [XmlElement("DefenseAttorney")]
    public AttorneyInfo DefenseAttorney { get; set; }

    [XmlElement("DefenseAttorneyList")]
    public List<DefenseAttorneyList> DefenseAttorneyList { get; set; }

    [XmlElement("FinalPlea")]
    public string FinalPlea { get; set; }

    [XmlElement("FineAmountInfo")]
    public FineAmountInfo FineAmountInfo { get; set; }

    [XmlElement("JudgeName")]
    public List<PersonName> JudgeName { get; set; }

    [XmlElement("JudicialDistrictOrCircuit")]
    public string JudicialDistrictOrCircuit { get; set; }

    [XmlElement("NormalizedCourtName")]
    public string NormalizedCourtName { get; set; }

    [XmlElement("OriginalCourtName")]
    public string OriginalCourtName { get; set; }

    [XmlElement("PreHearingFlag")]
    public string PreHearingFlag { get; set; }

    [XmlElement("ProsecutingAttorney")]
    public AttorneyInfo ProsecutingAttorney { get; set; }

    [XmlElement("ProsecutingAttorneyList")]
    public List<ProsecutingAttorneyList> ProsecutingAttorneyList { get; set; }

    [XmlElement("TypeOfTrial")]
    public string TypeOfTrial { get; set; }

    [XmlElement("Verdict")]
    public string Verdict { get; set; }

    [XmlElement("VerdictDate")]
    public string VerdictDate { get; set; }

    [XmlElement("DispositionDecision")]
    public string DispositionDecision { get; set; }

    [XmlElement("DispositionFinalDate")]
    public string DispositionFinalDate { get; set; }

    [XmlElement("DispositionCategory")]
    public string DispositionCategory { get; set; }

}
}