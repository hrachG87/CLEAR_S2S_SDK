using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaMonitorDeleteSubjectsResult")]
public class AdverseMediaMonitorDeleteSubjectsResult
{
    [XmlElement("Status")]
    public Status Status { get; set; }
}
