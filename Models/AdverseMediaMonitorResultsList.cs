using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaMonitorResultsList")]
public class AdverseMediaMonitorResultsList
{
    [XmlElement("ResultCount")]
    public int ResultCount { get; set; }

    [XmlElement("ListSummary")]
    public List<ListSummary> ListSummary { get; set; }

}
}