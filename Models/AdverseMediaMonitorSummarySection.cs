using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaMonitorSummarySection")]
public class AdverseMediaMonitorSummarySection
{
    [XmlElement("AdverseMediaMonitorSummaryRecord")]
    public AdverseMediaMonitorSummaryRecord AdverseMediaMonitorSummaryRecord { get; set; }

}
}