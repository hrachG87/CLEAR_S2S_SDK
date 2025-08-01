using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessAffiliationInfo")]
public class BusinessAffiliationInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("BusinessRelatedName")]
    public List<string> BusinessRelatedName { get; set; }

    [XmlElement("BusinessTradeName")]
    public string BusinessTradeName { get; set; }

    [XmlElement("BusinessWebAddress")]
    public string BusinessWebAddress { get; set; }

    [XmlElement("LegalBusinessName")]
    public string LegalBusinessName { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("SecondaryAddress")]
    public CommonDataAddress SecondaryAddress { get; set; }

    [XmlElement("SecondaryPhone")]
    public PhoneInfo SecondaryPhone { get; set; }

    [XmlElement("TypeofOrganization")]
    public string TypeofOrganization { get; set; }

    [XmlElement("YearEstablished")]
    public string YearEstablished { get; set; }

}