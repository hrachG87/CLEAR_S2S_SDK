using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessReportResults")]
public class BusinessReportResults
{
    [XmlElement("Status")]
    public ClearReportApiStatus Status { get; set; }

    [XmlElement("Uri")]
    public string Uri { get; set; }

    [XmlElement("NumberOfCandidates")]
    public int NumberOfCandidates { get; set; }

    [XmlElement("ReportCandidates")]
    public BusinessReportCandidates ReportCandidates { get; set; }
}
