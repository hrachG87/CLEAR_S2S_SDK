using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaUpdateMonitorRequest")]
public class AdverseMediaUpdateMonitorRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public AdverseMediaUpdateMonitorUserCriteria Criteria { get; set; }

}