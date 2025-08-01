using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("StateDocketRecord")]
public class StateDocketRecord
{
    [XmlElement("SummaryInfo")]
    public CourtSummaryInfo SummaryInfo { get; set; }

    [XmlElement("AppealsInfo")]
    public List<AppealsInfo> AppealsInfo { get; set; }

    [XmlElement("ArrestInfo")]
    public CourtDataArrestInfo ArrestInfo { get; set; }

    [XmlElement("ArrestList")]
    public List<CourtDataArrestInfo> ArrestList { get; set; }

    [XmlElement("BailInfo")]
    public List<CourtDataBailInfo> BailInfo { get; set; }

    [XmlElement("CaseInfo")]
    public CourtDataCaseInfo CaseInfo { get; set; }

    [XmlElement("ChargesInfo")]
    public List<CourtDataChargesInfo> ChargesInfo { get; set; }

    [XmlElement("ComplaintInfo")]
    public List<Complaint> ComplaintInfo { get; set; }

    [XmlElement("GeneralNote")]
    public List<string> GeneralNote { get; set; }

    [XmlElement("InvolvedAttorney")]
    public List<InvolvedAttorney> InvolvedAttorney { get; set; }

    [XmlElement("InvolvedParty")]
    public List<InvolvedParty> InvolvedParty { get; set; }

    [XmlElement("JudgmentInfo")]
    public List<JudgementInfo> JudgmentInfo { get; set; }

    [XmlElement("LowerDistrictCourtInfo")]
    public List<LowerDistrictCourtInfo> LowerDistrictCourtInfo { get; set; }

    [XmlElement("MatchPartyList")]
    public List<MatchPartyList> MatchPartyList { get; set; }

    [XmlElement("PaymentEntry")]
    public PaymentEntry PaymentEntry { get; set; }

    [XmlElement("PleaInfo")]
    public List<CourtPleaInfo> PleaInfo { get; set; }

    [XmlElement("SentencingInfo")]
    public List<CourtSentencingInfo> SentencingInfo { get; set; }

    [XmlElement("Synopsis")]
    public Synopsis Synopsis { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("DocketProceedings")]
    public List<DocketProceedings> DocketProceedings { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}