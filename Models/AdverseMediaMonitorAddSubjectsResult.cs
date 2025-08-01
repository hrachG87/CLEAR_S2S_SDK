using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaMonitorAddSubjectsResult")]
public class AdverseMediaMonitorAddSubjectsResult
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("Uri")]
    public string Uri { get; set; }

    [XmlElement("AlertSubjectsCount")]
    public int AlertSubjectsCount { get; set; }

    [XmlElement("AlertSubjects")]
    public AlertSubjects AlertSubjects { get; set; }
}
