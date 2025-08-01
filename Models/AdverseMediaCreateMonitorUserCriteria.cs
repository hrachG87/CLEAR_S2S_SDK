using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaCreateMonitorUserCriteria")]
public class AdverseMediaCreateMonitorUserCriteria
{
    [XmlElement("Criteria")]
    public AdverseMediaMonitorCriteria Criteria { get; set; }

}
}