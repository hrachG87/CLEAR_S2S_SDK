using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaDeleteMonitorCriteria")]
public class AdverseMediaDeleteMonitorCriteria
{
    [XmlElement("ListName")]
    public string ListName { get; set; }

}
}