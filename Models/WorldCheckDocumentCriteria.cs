using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WorldCheckDocumentCriteria")]
public class WorldCheckDocumentCriteria
{
    [XmlElement("PersonName")]
    public WorldCheckNameCriteria PersonName { get; set; }

    [XmlElement("IncludePersonNameAkaOption")]
    public bool IncludePersonNameAkaOption { get; set; }

    [XmlElement("PassportNumber")]
    public string PassportNumber { get; set; }

    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("AgeInfo")]
    public AgeCriteria AgeInfo { get; set; }

    [XmlElement("WorldCheckUniqueId")]
    public string WorldCheckUniqueId { get; set; }

    [XmlElement("EntityName")]
    public string EntityName { get; set; }

    [XmlElement("IncludeEntityNameAkaOption")]
    public bool IncludeEntityNameAkaOption { get; set; }

    [XmlElement("Location")]
    public string Location { get; set; }

    [XmlElement("Country")]
    public string Country { get; set; }

    [XmlElement("RestrictedDate")]
    public string RestrictedDate { get; set; }

    [XmlElement("ProfileType")]
    public string ProfileType { get; set; }

    [XmlElement("KeywordType")]
    public string KeywordType { get; set; }

    [XmlElement("Category")]
    public string Category { get; set; }

    [XmlElement("SubCategory")]
    public string SubCategory { get; set; }

    [XmlElement("FullTextQuery")]
    public string FullTextQuery { get; set; }

    [XmlElement("DocGuid")]
    public string DocGuid { get; set; }
}
