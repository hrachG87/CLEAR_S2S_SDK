using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaMonitorReportOptions")]
public class AdverseMediaMonitorReportOptions
{
    [XmlElement("MonitorArticleOrder")]
    public string MonitorArticleOrder { get; set; }

    [XmlElement("ScoreThreshold")]
    public int ScoreThreshold { get; set; }

    [XmlElement("DisplayHitTagsOnly")]
    public bool DisplayHitTagsOnly { get; set; }

}
}