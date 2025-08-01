using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessSearchRequest")]
public class BusinessSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public BusinessUserCriteria Criteria { get; set; }

    [XmlElement("Datasources")]
    public BusinessDatasources Datasources { get; set; }
}
