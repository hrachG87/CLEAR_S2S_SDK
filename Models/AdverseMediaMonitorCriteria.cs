using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaMonitorCriteria")]
public class AdverseMediaMonitorCriteria
{
    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("AlertSubjects")]
    public AlertSubjects AlertSubjects { get; set; }

    [XmlElement("CategoryTags")]
    public CategoryTags CategoryTags { get; set; }

    [XmlElement("Delivery")]
    public Delivery Delivery { get; set; }

    [XmlElement("SanctionOverrideList")]
    public SanctionOverrideList SanctionOverrideList { get; set; }

}
}