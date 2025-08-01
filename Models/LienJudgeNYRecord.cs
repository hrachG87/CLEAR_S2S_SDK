using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("LienJudgeNYRecord")]
public class LienJudgeNYRecord
{
    [XmlElement("Creditor")]
    public List<Creditor> Creditor { get; set; }

    [XmlElement("Debtor")]
    public List<Debtor> Debtor { get; set; }

    [XmlElement("FilingInfo")]
    public CourtDataFilingInfo FilingInfo { get; set; }

    [XmlElement("OtherParty")]
    public List<OtherParty> OtherParty { get; set; }

    [XmlElement("LienInfo")]
    public LienInfo LienInfo { get; set; }

    [XmlElement("Comment")]
    public List<string> Comment { get; set; }

    [XmlElement("CommentDate")]
    public List<string> CommentDate { get; set; }

    [XmlElement("Court")]
    public string Court { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
