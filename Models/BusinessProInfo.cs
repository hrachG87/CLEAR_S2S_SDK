using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessProInfo")]
public class BusinessProInfo
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("LegalBusinessName")]
    public string LegalBusinessName { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("PrimaryISOCountryCode")]
    public string PrimaryISOCountryCode { get; set; }

    [XmlElement("SecondaryAddress")]
    public CommonDataAddress SecondaryAddress { get; set; }

    [XmlElement("SecondaryISOCountryCode")]
    public string SecondaryISOCountryCode { get; set; }

    [XmlElement("PhoneInfo")]
    public PhoneInfo PhoneInfo { get; set; }

    [XmlElement("WebAddress")]
    public string WebAddress { get; set; }

    [XmlElement("EmailAddress")]
    public string EmailAddress { get; set; }

    [XmlElement("ContactInfo")]
    public ExecutiveInfo ContactInfo { get; set; }

    [XmlElement("ExecInfo")]
    public List<ExecutiveInfo> ExecInfo { get; set; }

    [XmlElement("BusinessContacts")]
    public List<BusinessContacts> BusinessContacts { get; set; }

}