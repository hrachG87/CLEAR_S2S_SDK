using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DECorpSearchRequest")]
public class DECorpSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public DECorpCriteria Criteria { get; set; }

}