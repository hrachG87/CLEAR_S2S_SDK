using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformPersonSearchRequest")]
public class RiskInformPersonSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public RiskInformPersonUserCriteria Criteria { get; set; }
}
