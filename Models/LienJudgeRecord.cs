using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("LienJudgeRecord")]
public class LienJudgeRecord
{
    [XmlElement("Creditor")]
    public List<Creditor> Creditor { get; set; }

    [XmlElement("Debtor")]
    public List<Debtor> Debtor { get; set; }

    [XmlElement("FilingInfo")]
    public List<CourtDataFilingInfo> FilingInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
