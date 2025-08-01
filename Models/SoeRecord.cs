using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SoeRecord")]
public class SoeRecord
{
    [XmlElement("Article")]
    public string Article { get; set; }

    [XmlElement("ParentEntryType")]
    public string ParentEntryType { get; set; }

    [XmlElement("Score")]
    public double Score { get; set; }

    [XmlElement("Term")]
    public string Term { get; set; }

    [XmlElement("MasterEntry")]
    public string MasterEntry { get; set; }

    [XmlElement("MatchedEntry")]
    public string MatchedEntry { get; set; }

    [XmlElement("MatchedEntryType")]
    public string MatchedEntryType { get; set; }

    [XmlElement("ParentEntry")]
    public string ParentEntry { get; set; }

    [XmlElement("SoeId")]
    public string SoeId { get; set; }

    [XmlElement("EntityReviewDate")]
    public string EntityReviewDate { get; set; }

    [XmlElement("EntityRegistrationNumber")]
    public string EntityRegistrationNumber { get; set; }

    [XmlElement("EntityLegalForm")]
    public string EntityLegalForm { get; set; }

    [XmlElement("EntityTaxNumber")]
    public string EntityTaxNumber { get; set; }

    [XmlElement("Sector")]
    public string Sector { get; set; }

    [XmlElement("DateOwnershipUpdated")]
    public string DateOwnershipUpdated { get; set; }

    [XmlElement("StateTotalQuote")]
    public string StateTotalQuote { get; set; }

    [XmlElement("OwnershipQuote")]
    public string OwnershipQuote { get; set; }

    [XmlElement("OwnerCountry")]
    public string OwnerCountry { get; set; }

    [XmlElement("OwnerCategory")]
    public string OwnerCategory { get; set; }

    [XmlElement("OwnerName")]
    public string OwnerName { get; set; }

    [XmlElement("Category")]
    public string Category { get; set; }

    [XmlElement("Address")]
    public string Address { get; set; }

    [XmlElement("Aka")]
    public string Aka { get; set; }

    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("Type")]
    public string Type { get; set; }

    [XmlElement("AmRelevance")]
    public double AmRelevance { get; set; }

    [XmlElement("UserReference")]
    public string UserReference { get; set; }

    [XmlElement("AdditionalInfo")]
    public List<AdditionalInfo> AdditionalInfo { get; set; }

    [XmlElement("RawAdditionalInfoList")]
    public RawAdditionalInfoList RawAdditionalInfoList { get; set; }

}