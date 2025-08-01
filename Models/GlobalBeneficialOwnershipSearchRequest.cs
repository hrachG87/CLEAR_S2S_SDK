using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GlobalBeneficialOwnershipSearchRequest")]
public class GlobalBeneficialOwnershipSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public GlobalBeneficialOwnershipCriteria Criteria { get; set; }

}