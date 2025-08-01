using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MarijuanaRelatedBusinessRecord")]
public class MarijuanaRelatedBusinessRecord
{
    [XmlElement("Name")]
    public PersonName Name { get; set; }

    [XmlElement("BusinessNameType")]
    public string BusinessNameType { get; set; }

    [XmlElement("PersonBirthDate")]
    public string PersonBirthDate { get; set; }

    [XmlElement("BusinessTier")]
    public string BusinessTier { get; set; }

    [XmlElement("BusinessLicenseNumber")]
    public string BusinessLicenseNumber { get; set; }

    [XmlElement("BusinessCIK")]
    public string BusinessCIK { get; set; }

    [XmlElement("BusinessFEIN")]
    public string BusinessFEIN { get; set; }

    [XmlElement("BusinessTicker")]
    public string BusinessTicker { get; set; }

    [XmlElement("BusinessStockExchange")]
    public string BusinessStockExchange { get; set; }

    [XmlElement("LastReportedDate")]
    public string LastReportedDate { get; set; }

    [XmlElement("Address")]
    public List<CommonDataAddress> Address { get; set; }

    [XmlElement("PhoneInfo")]
    public List<PhoneInfo> PhoneInfo { get; set; }

    [XmlElement("BusinessAKA")]
    public List<BusinessAKA> BusinessAKA { get; set; }

    [XmlElement("PersonAKA")]
    public List<PersonName> PersonAKA { get; set; }

    [XmlElement("WebsiteInfo")]
    public List<WebsiteInfo> WebsiteInfo { get; set; }

    [XmlElement("Email")]
    public List<string> Email { get; set; }

    [XmlElement("BusinessRegistrationInfo")]
    public List<BusinessRegistrationInfo> BusinessRegistrationInfo { get; set; }

    [XmlElement("MarijuanaLicenseInfo")]
    public List<MarijuanaLicenseInfo> MarijuanaLicenseInfo { get; set; }

    [XmlElement("RelatedPartiesInfo")]
    public List<RelatedPartiesInfo> RelatedPartiesInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}
}