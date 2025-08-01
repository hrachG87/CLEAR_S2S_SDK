using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaMonitorReportCriteriaContainer")]
public class AdverseMediaMonitorReportCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public AdverseMediaMonitorReportCriteria ReportCriteria { get; set; }

    [XmlElement("ReportOptions")]
    public AdverseMediaMonitorReportOptions ReportOptions { get; set; }
}
