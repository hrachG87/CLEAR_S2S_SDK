using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessDocumentSearchRequest")]
public class BusinessDocumentSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public BusinessDocumentUserCriteria Criteria { get; set; }

    [XmlElement("Datasources")]
    public BusinessDocumentDatasources Datasources { get; set; }

    [XmlElement("BusinessDataSets")]
    public BusinessDataSets BusinessDataSets { get; set; }

}