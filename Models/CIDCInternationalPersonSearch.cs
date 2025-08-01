using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CIDCInternationalPersonSearch")]
public class CIDCInternationalPersonSearch
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("CIDCInternationalPersonSearchRequest")]
    public CIDCInternationalPersonSearchRequest CIDCInternationalPersonSearchRequest { get; set; }
}
