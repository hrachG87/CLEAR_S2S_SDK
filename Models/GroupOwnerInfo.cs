using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GroupOwnerInfo")]
public class GroupOwnerInfo
{
    [XmlElement("OwnerRelationship")]
    public string OwnerRelationship { get; set; }

    [XmlElement("OwnerRights")]
    public string OwnerRights { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }
}
