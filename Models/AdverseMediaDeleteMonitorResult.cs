using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaDeleteMonitorResult")]
public class AdverseMediaDeleteMonitorResult
{
    [XmlElement("Status")]
    public Status Status { get; set; }

}
}