using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaMonitorReportRequest")]
public class AdverseMediaMonitorReportRequest
{
    [XmlElement("PermissiblePurpose")]
    public ReportPermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public AdverseMediaMonitorReportCriteriaContainer Criteria { get; set; }
}
