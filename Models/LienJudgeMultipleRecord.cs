using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("LienJudgeMultipleRecord")]
public class LienJudgeMultipleRecord
{
    [XmlElement("Creditor")]
    public List<Creditor> Creditor { get; set; }

    [XmlElement("Debtor")]
    public List<Debtor> Debtor { get; set; }

    [XmlElement("Subjudgments")]
    public List<Subjudgments> Subjudgments { get; set; }

    [XmlElement("JudgmentInfo")]
    public List<CourtDataJudgmentInfo> JudgmentInfo { get; set; }

    [XmlElement("LienInfo")]
    public List<LienInfo> LienInfo { get; set; }

    [XmlElement("CommentInfo")]
    public List<CommentInfo> CommentInfo { get; set; }

    [XmlElement("NumberofSubjudgments")]
    public string NumberofSubjudgments { get; set; }

    [XmlElement("LienJudgeFilingInfo")]
    public List<CourtDataFilingInfo> LienJudgeFilingInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
