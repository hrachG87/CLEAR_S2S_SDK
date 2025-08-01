using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessReportCandidates")]
public class BusinessReportCandidates
{
    [XmlElement("ReportCandidate")]
    public List<BusinessReportCandidate> ReportCandidate { get; set; }

}