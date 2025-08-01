using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SubjudgmentInfo")]
public class SubjudgmentInfo
{
    [XmlElement("SubjudgmentFilingDate")]
    public string SubjudgmentFilingDate { get; set; }

    [XmlElement("Comment")]
    public List<string> Comment { get; set; }

    [XmlElement("DispositionInfo")]
    public CaseDisposition DispositionInfo { get; set; }

    [XmlElement("StatusInfo")]
    public StatusInfo StatusInfo { get; set; }
}
