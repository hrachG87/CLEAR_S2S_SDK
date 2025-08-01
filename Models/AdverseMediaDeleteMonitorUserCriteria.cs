using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaDeleteMonitorUserCriteria")]
public class AdverseMediaDeleteMonitorUserCriteria
{
    [XmlElement("Criteria")]
    public AdverseMediaDeleteMonitorCriteria Criteria { get; set; }

}
}