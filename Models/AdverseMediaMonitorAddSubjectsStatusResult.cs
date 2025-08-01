using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaMonitorAddSubjectsStatusResult")]
public class AdverseMediaMonitorAddSubjectsStatusResult
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("AlertSubjectsCount")]
    public int AlertSubjectsCount { get; set; }

    [XmlElement("AlertSubjects")]
    public AlertSubjects AlertSubjects { get; set; }
}
