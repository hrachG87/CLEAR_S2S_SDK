using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaCreateMonitorRequest")]
public class AdverseMediaCreateMonitorRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public AdverseMediaCreateMonitorUserCriteria Criteria { get; set; }

    [XmlElement("AsyncCreate")]
    public bool AsyncCreate { get; set; }

}
}