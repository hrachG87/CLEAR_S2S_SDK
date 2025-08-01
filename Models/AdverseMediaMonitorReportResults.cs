using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaMonitorReportResults")]
public class AdverseMediaMonitorReportResults
{
    [XmlElement("Status")]
    public ClearReportApiStatus Status { get; set; }

    [XmlElement("Uri")]
    public string Uri { get; set; }
}
