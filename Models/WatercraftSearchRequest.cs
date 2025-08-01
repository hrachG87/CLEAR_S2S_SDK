using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WatercraftSearchRequest")]
public class WatercraftSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public WatercraftUserCriteria Criteria { get; set; }

    [XmlElement("Datasources")]
    public WatercraftDatasources Datasources { get; set; }

    [XmlElement("WatercraftDatasets")]
    public WatercraftDatasets WatercraftDatasets { get; set; }

}