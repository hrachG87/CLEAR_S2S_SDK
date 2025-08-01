using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaMonitorAddSubjectsCriteria")]
public class AdverseMediaMonitorAddSubjectsCriteria
{
    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("AlertSubjects")]
    public AlertSubjects AlertSubjects { get; set; }
}
