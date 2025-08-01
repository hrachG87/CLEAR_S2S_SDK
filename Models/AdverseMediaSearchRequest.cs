using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaSearchRequest")]
public class AdverseMediaSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public AdverseMediaCriteria Criteria { get; set; }

    [XmlElement("AdverseMediaSanctions")]
    public AdverseMediaSanctions AdverseMediaSanctions { get; set; }

    [XmlElement("SanctionOverrideList")]
    public SanctionOverrideList SanctionOverrideList { get; set; }

}