using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaMonitorDeleteSubjectsResult")]
public class AdverseMediaMonitorDeleteSubjectsResult
{
    [XmlElement("Status")]
    public Status Status { get; set; }

}
}