using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AssociateInfo")]
public class AssociateInfo
{
    [XmlElement("PersonInfo")]
    public PersonReportPersonInfo PersonInfo { get; set; }

    [XmlElement("EntityId")]
    public string EntityId { get; set; }

    [XmlElement("AddressInfo")]
    public List<PersonReportAddressInfo> AddressInfo { get; set; }

    [XmlElement("StrengthOfAssociation")]
    public int StrengthOfAssociation { get; set; }

    [XmlElement("Associations")]
    public Associations Associations { get; set; }

    [XmlElement("TREntityId")]
    public string TREntityId { get; set; }
}
