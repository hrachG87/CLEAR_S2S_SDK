using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaMonitorSummarySection")]
public class AdverseMediaMonitorSummarySection
{
    [XmlElement("AdverseMediaMonitorSummaryRecord")]
    public AdverseMediaMonitorSummaryRecord AdverseMediaMonitorSummaryRecord { get; set; }

}