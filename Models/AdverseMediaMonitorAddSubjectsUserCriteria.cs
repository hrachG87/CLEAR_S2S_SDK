using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaMonitorAddSubjectsUserCriteria")]
public class AdverseMediaMonitorAddSubjectsUserCriteria
{
    [XmlElement("AdverseMediaMonitorAddSubjectsCriteria")]
    public AdverseMediaMonitorAddSubjectsCriteria AdverseMediaMonitorAddSubjectsCriteria { get; set; }

}