using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DistrictCourtDocketRecord")]
public class DistrictCourtDocketRecord
{
    [XmlElement("SummaryInfo")]
    public CourtSummaryInfo SummaryInfo { get; set; }

    [XmlElement("CaseList")]
    public List<CourtDataCaseInfo> CaseList { get; set; }

    [XmlElement("Cause")]
    public List<string> Cause { get; set; }

    [XmlElement("Complaint")]
    public List<Complaint> Complaint { get; set; }

    [XmlElement("DefendantDiversity")]
    public List<string> DefendantDiversity { get; set; }

    [XmlElement("DefendantList")]
    public List<InvolvedParty> DefendantList { get; set; }

    [XmlElement("HigherCourtInfo")]
    public HigherCourtInfo HigherCourtInfo { get; set; }

    [XmlElement("LeadDocketNumber")]
    public string LeadDocketNumber { get; set; }

    [XmlElement("OtherPartyList")]
    public List<InvolvedParty> OtherPartyList { get; set; }

    [XmlElement("PlaintiffDiversity")]
    public List<string> PlaintiffDiversity { get; set; }

    [XmlElement("PlaintiffList")]
    public List<InvolvedParty> PlaintiffList { get; set; }

    [XmlElement("SummaryCaseNum")]
    public List<string> SummaryCaseNum { get; set; }

    [XmlElement("Synopsis")]
    public Synopsis Synopsis { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("Patent")]
    public List<Patent> Patent { get; set; }

    [XmlElement("PublishedOpinion")]
    public MDLInfo PublishedOpinion { get; set; }

    [XmlElement("LeadCase")]
    public MDLInfo LeadCase { get; set; }

    [XmlElement("DocketEntries")]
    public List<DocketEntries> DocketEntries { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("MDLJurisdiction")]
    public MDLInfo MDLJurisdiction { get; set; }

    [XmlElement("JPMLAssocCase")]
    public List<MDLInfo> JPMLAssocCase { get; set; }

    [XmlElement("MDLCaseInfo")]
    public MDLCaseInfo MDLCaseInfo { get; set; }

}