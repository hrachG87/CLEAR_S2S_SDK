using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ReportCandidates")]
public class ReportCandidates
{
    [XmlElement("ReportCandidate")]
    public List<ReportCandidate> ReportCandidate { get; set; }
}
