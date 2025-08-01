using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaMonitorAnalyticsResponse")]
public class AdverseMediaMonitorAnalyticsResponse
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("AnalyticsResult")]
    public AnalyticsResult AnalyticsResult { get; set; }

}