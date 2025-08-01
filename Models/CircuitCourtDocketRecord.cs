using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CircuitCourtDocketRecord")]
public class CircuitCourtDocketRecord
{
    [XmlElement("SummaryInfo")]
    public CourtSummaryInfo SummaryInfo { get; set; }

    [XmlElement("CaseList")]
    public List<CourtDataCaseInfo> CaseList { get; set; }

    [XmlElement("CurrentCases")]
    public List<CurrentCases> CurrentCases { get; set; }

    [XmlElement("HigherCourtInfo")]
    public HigherCourtInfo HigherCourtInfo { get; set; }

    [XmlElement("InvolvedParty")]
    public List<InvolvedParty> InvolvedParty { get; set; }

    [XmlElement("LowerDistrictCourtInfo")]
    public List<LowerDistrictCourtInfo> LowerDistrictCourtInfo { get; set; }

    [XmlElement("PrimaryCase")]
    public CourtDataCaseInfo PrimaryCase { get; set; }

    [XmlElement("PriorCases")]
    public List<CourtDataCaseInfo> PriorCases { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("DocketEntries")]
    public List<DocketEntries> DocketEntries { get; set; }

}