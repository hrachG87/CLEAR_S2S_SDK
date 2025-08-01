using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonDocumentSearchRequest")]
public class PersonDocumentSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public PersonDocumentUserCriteria Criteria { get; set; }

    [XmlElement("Datasources")]
    public PersonDocumentDataSources Datasources { get; set; }

    [XmlElement("PeopleDatasets")]
    public PeopleDatasets PeopleDatasets { get; set; }
}
