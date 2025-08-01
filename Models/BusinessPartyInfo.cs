using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessPartyInfo")]
public class BusinessPartyInfo
{
    [XmlElement("PartyName")]
    public List<string> PartyName { get; set; }

    [XmlElement("PersonName")]
    public List<PersonName> PersonName { get; set; }

    [XmlElement("BusinessName")]
    public List<string> BusinessName { get; set; }

    [XmlElement("BusinessDUNSNumber")]
    public string BusinessDUNSNumber { get; set; }

    [XmlElement("HeadqtrDUNSNumber")]
    public string HeadqtrDUNSNumber { get; set; }

    [XmlElement("TypeOfParty")]
    public string TypeOfParty { get; set; }

    [XmlElement("TaxID")]
    public string TaxID { get; set; }

    [XmlElement("address")]
    public CommonDataAddress address { get; set; }
}
