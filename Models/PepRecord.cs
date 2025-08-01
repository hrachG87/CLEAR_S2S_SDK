using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PepRecord")]
public class PepRecord
{
    [XmlElement("ParentEntryType")]
    public string ParentEntryType { get; set; }

    [XmlElement("Score")]
    public double Score { get; set; }

    [XmlElement("Term")]
    public string Term { get; set; }

    [XmlElement("MatchedEntry")]
    public string MatchedEntry { get; set; }

    [XmlElement("MatchedEntryType")]
    public string MatchedEntryType { get; set; }

    [XmlElement("ParentEntry")]
    public string ParentEntry { get; set; }

    [XmlElement("PepId")]
    public string PepId { get; set; }

    [XmlElement("Code")]
    public string Code { get; set; }

    [XmlElement("Country")]
    public string Country { get; set; }

    [XmlElement("Category")]
    public string Category { get; set; }

    [XmlElement("Function")]
    public string Function { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("Gender")]
    public string Gender { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("Article")]
    public string Article { get; set; }

    [XmlElement("MasterEntry")]
    public string MasterEntry { get; set; }

    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("Type")]
    public string Type { get; set; }

    [XmlElement("Relevance")]
    public double Relevance { get; set; }

    [XmlElement("UserReference")]
    public string UserReference { get; set; }

    [XmlElement("AdditionalInfo")]
    public List<AdditionalInfo> AdditionalInfo { get; set; }

    [XmlElement("RawAdditionalInfoList")]
    public RawAdditionalInfoList RawAdditionalInfoList { get; set; }

}