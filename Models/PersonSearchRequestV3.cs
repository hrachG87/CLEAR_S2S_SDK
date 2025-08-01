using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonSearchRequestV3")]
public class PersonSearchRequestV3
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