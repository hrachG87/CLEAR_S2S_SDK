using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonAssociateAnalyticsRequest")]
public class PersonAssociateAnalyticsRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public PersonAssociateAnalyticsUserCriteria Criteria { get; set; }

}