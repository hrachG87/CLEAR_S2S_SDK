using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaMonitorDeleteSubjectsUserCriteria")]
public class AdverseMediaMonitorDeleteSubjectsUserCriteria
{
    [XmlElement("AdverseMediaMonitorDeleteSubjectsCriteria")]
    public AdverseMediaMonitorDeleteSubjectsCriteria AdverseMediaMonitorDeleteSubjectsCriteria { get; set; }

}