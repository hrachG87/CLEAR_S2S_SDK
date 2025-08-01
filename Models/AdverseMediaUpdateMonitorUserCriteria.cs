using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaUpdateMonitorUserCriteria")]
public class AdverseMediaUpdateMonitorUserCriteria
{
    [XmlElement("Criteria")]
    public AdverseMediaMonitorCriteria Criteria { get; set; }

}
}