using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SoeAdditionalInfo")]
public class SoeAdditionalInfo
{
    [XmlElement("SoeId")]
    public string SoeId { get; set; }

    [XmlElement("Address")]
    public string Address { get; set; }

    [XmlElement("AddressOriginalLanguage")]
    public string AddressOriginalLanguage { get; set; }

    [XmlElement("Aka")]
    public string Aka { get; set; }

    [XmlElement("AkaOriginalLanguage")]
    public string AkaOriginalLanguage { get; set; }

    [XmlElement("Category")]
    public string Category { get; set; }

    [XmlElement("DateOwnershipUpdated")]
    public string DateOwnershipUpdated { get; set; }

    [XmlElement("EntityReviewed")]
    public string EntityReviewed { get; set; }

    [XmlElement("Sector")]
    public string Sector { get; set; }

    [XmlElement("OwnerName")]
    public string OwnerName { get; set; }

    [XmlElement("OwnerCountry")]
    public string OwnerCountry { get; set; }

    [XmlElement("OwnerCategory")]
    public string OwnerCategory { get; set; }

    [XmlElement("EntityLegalForm")]
    public string EntityLegalForm { get; set; }

    [XmlElement("OwnershipQuote")]
    public string OwnershipQuote { get; set; }

    [XmlElement("EntityRegistrationNumber")]
    public string EntityRegistrationNumber { get; set; }

    [XmlElement("EntityTaxNumber")]
    public string EntityTaxNumber { get; set; }

    [XmlElement("EntityWebsite")]
    public string EntityWebsite { get; set; }

    [XmlElement("StateTotalQuote")]
    public string StateTotalQuote { get; set; }

    [XmlElement("Guid")]
    public string Guid { get; set; }

}
}