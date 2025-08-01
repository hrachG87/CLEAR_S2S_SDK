using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonSearchRequest")]
public class PersonSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public PersonSearchUserCriteria Criteria { get; set; }

    [XmlElement("Datasources")]
    public PersonDatasources Datasources { get; set; }
}
