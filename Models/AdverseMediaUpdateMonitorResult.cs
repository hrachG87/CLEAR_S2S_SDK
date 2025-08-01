using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaUpdateMonitorResult")]
public class AdverseMediaUpdateMonitorResult
{
    [XmlElement("Status")]
    public Status Status { get; set; }

}
}