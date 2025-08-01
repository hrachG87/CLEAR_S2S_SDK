using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaMonitorDeleteSubjectsUserCriteria")]
public class AdverseMediaMonitorDeleteSubjectsUserCriteria
{
    [XmlElement("AdverseMediaMonitorDeleteSubjectsCriteria")]
    public AdverseMediaMonitorDeleteSubjectsCriteria AdverseMediaMonitorDeleteSubjectsCriteria { get; set; }

}
}