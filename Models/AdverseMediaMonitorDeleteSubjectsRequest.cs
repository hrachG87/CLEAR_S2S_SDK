using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaMonitorDeleteSubjectsRequest")]
public class AdverseMediaMonitorDeleteSubjectsRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public AdverseMediaMonitorDeleteSubjectsUserCriteria Criteria { get; set; }

}