using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaMonitorAddSubjectsUserCriteria")]
public class AdverseMediaMonitorAddSubjectsUserCriteria
{
    [XmlElement("AdverseMediaMonitorAddSubjectsCriteria")]
    public AdverseMediaMonitorAddSubjectsCriteria AdverseMediaMonitorAddSubjectsCriteria { get; set; }

}
}