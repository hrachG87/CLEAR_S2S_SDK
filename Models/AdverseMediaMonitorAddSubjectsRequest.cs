using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaMonitorAddSubjectsRequest")]
public class AdverseMediaMonitorAddSubjectsRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public AdverseMediaMonitorAddSubjectsUserCriteria Criteria { get; set; }

    [XmlElement("AsyncAdd")]
    public bool AsyncAdd { get; set; }
}
