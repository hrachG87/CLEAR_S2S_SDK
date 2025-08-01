using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaMonitorResultsPage")]
public class AdverseMediaMonitorResultsPage
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("ResultId")]
    public string ResultId { get; set; }

    [XmlElement("StartIndex")]
    public int StartIndex { get; set; }

    [XmlElement("EndIndex")]
    public int EndIndex { get; set; }

    [XmlElement("AdverseMediaMonitorResultsList")]
    public AdverseMediaMonitorResultsList AdverseMediaMonitorResultsList { get; set; }

}
}