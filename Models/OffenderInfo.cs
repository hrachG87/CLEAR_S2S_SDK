using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OffenderInfo")]
public class OffenderInfo
{
    [XmlElement("AmendedCharges")]
    public string AmendedCharges { get; set; }

    [XmlElement("AmendedChargesDate")]
    public string AmendedChargesDate { get; set; }

    [XmlElement("AmendedOffense")]
    public string AmendedOffense { get; set; }

    [XmlElement("AmendedOffenseDate")]
    public string AmendedOffenseDate { get; set; }

    [XmlElement("AppealStatus")]
    public string AppealStatus { get; set; }

    [XmlElement("AppealDate")]
    public string AppealDate { get; set; }

    [XmlElement("ArraignmentDate")]
    public string ArraignmentDate { get; set; }

    [XmlElement("ArrestAgency")]
    public string ArrestAgency { get; set; }

    [XmlElement("ArrestDate")]
    public string ArrestDate { get; set; }

    [XmlElement("ArrestWarrantFlag")]
    public string ArrestWarrantFlag { get; set; }

    [XmlElement("BailInfo")]
    public CriminalDataBailInfo BailInfo { get; set; }

    [XmlElement("BookingInfo")]
    public BookingInfo BookingInfo { get; set; }

    [XmlElement("CaseDispositionFinalDate")]
    public string CaseDispositionFinalDate { get; set; }

    [XmlElement("CaseDispositionDecisionCategoryText")]
    public string CaseDispositionDecisionCategoryText { get; set; }

    [XmlElement("CaseInfo")]
    public CriminalDataCaseInfo CaseInfo { get; set; }

    [XmlElement("CitationNumber")]
    public string CitationNumber { get; set; }

    [XmlElement("CrimeDate")]
    public string CrimeDate { get; set; }

    [XmlElement("CrimeIndicators")]
    public CrimeIndicators CrimeIndicators { get; set; }

    [XmlElement("CrimeSeverity")]
    public string CrimeSeverity { get; set; }

    [XmlElement("CriminalOffense")]
    public string CriminalOffense { get; set; }

    [XmlElement("ConvictDate")]
    public string ConvictDate { get; set; }

    [XmlElement("CourtCounty")]
    public string CourtCounty { get; set; }

    [XmlElement("CourtName")]
    public string CourtName { get; set; }

    [XmlElement("CustodyDate")]
    public string CustodyDate { get; set; }

    [XmlElement("CustodyLocation")]
    public string CustodyLocation { get; set; }

    [XmlElement("DispositionCharges")]
    public string DispositionCharges { get; set; }

    [XmlElement("DispositionChargesDate")]
    public string DispositionChargesDate { get; set; }

    [XmlElement("DocumentFiledDate")]
    public string DocumentFiledDate { get; set; }

    [XmlElement("FineAmountInfo")]
    public FineAmountInfo FineAmountInfo { get; set; }

    [XmlElement("InitialCharges")]
    public string InitialCharges { get; set; }

    [XmlElement("InitialChargesDate")]
    public string InitialChargesDate { get; set; }

    [XmlElement("InmateReleaseInfo")]
    public InmateReleaseInfo InmateReleaseInfo { get; set; }

    [XmlElement("JudgeName")]
    public List<string> JudgeName { get; set; }

    [XmlElement("ParoleInfo")]
    public ParoleInfo ParoleInfo { get; set; }

    [XmlElement("PleaInfo")]
    public CriminalPleaInfo PleaInfo { get; set; }

    [XmlElement("ProbationInfo")]
    public ProbationInfo ProbationInfo { get; set; }

    [XmlElement("OffenderPriorInfo")]
    public OffenderPriorInfo OffenderPriorInfo { get; set; }

    [XmlElement("OffenderSequenceNumber")]
    public string OffenderSequenceNumber { get; set; }

    [XmlElement("OffenseLocation")]
    public string OffenseLocation { get; set; }

    [XmlElement("OffenseStatus")]
    public string OffenseStatus { get; set; }

    [XmlElement("OffenseStatusDate")]
    public string OffenseStatusDate { get; set; }

    [XmlElement("PriorOffenseIndicator")]
    public string PriorOffenseIndicator { get; set; }

    [XmlElement("SentencingInfo")]
    public CriminalSentencingInfo SentencingInfo { get; set; }

    [XmlElement("StatuteViolated")]
    public string StatuteViolated { get; set; }

    [XmlElement("TypeOfTrial")]
    public string TypeOfTrial { get; set; }

    [XmlElement("WarrantDate")]
    public string WarrantDate { get; set; }

    [XmlElement("WarrrantDescription")]
    public string WarrrantDescription { get; set; }

    [XmlElement("WarrantIssueDate")]
    public string WarrantIssueDate { get; set; }

    [XmlElement("Verdict")]
    public string Verdict { get; set; }

    [XmlElement("AdditionalInfo")]
    public List<CriminalDataAdditionalInfo> AdditionalInfo { get; set; }

    [XmlElement("CriminalCategory")]
    public CriminalCategory CriminalCategory { get; set; }

}