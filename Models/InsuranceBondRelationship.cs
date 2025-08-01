using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("InsuranceBondRelationship")]
public class InsuranceBondRelationship
{
    [XmlElement("BondingCompany")]
    public string BondingCompany { get; set; }

    [XmlElement("Address")]
    public Address Address { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("BondType")]
    public string BondType { get; set; }
}
