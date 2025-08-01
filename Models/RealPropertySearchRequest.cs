using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RealPropertySearchRequest")]
public class RealPropertySearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public RealPropertyUserCriteria Criteria { get; set; }

    [XmlElement("Datasources")]
    public RealPropertyDatasources Datasources { get; set; }

    [XmlElement("RealPropertyDatasets")]
    public RealPropertyDatasets RealPropertyDatasets { get; set; }
}
