using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaMonitorDeleteSubjectsCriteria")]
public class AdverseMediaMonitorDeleteSubjectsCriteria
{
    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("AlertSubjects")]
    public AlertSubjects AlertSubjects { get; set; }

}
}