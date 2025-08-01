using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PepAdditionalInfo")]
public class PepAdditionalInfo
{
    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("BirthDate")]
    public string BirthDate { get; set; }

    [XmlElement("Gender")]
    public string Gender { get; set; }

    [XmlElement("Function")]
    public string Function { get; set; }

    [XmlElement("Category")]
    public string Category { get; set; }

    [XmlElement("PepId")]
    public string PepId { get; set; }

    [XmlElement("Country")]
    public string Country { get; set; }

    [XmlElement("Code")]
    public string Code { get; set; }

    [XmlElement("Alias")]
    public string Alias { get; set; }

    [XmlElement("AliasOriginalLanguage")]
    public string AliasOriginalLanguage { get; set; }

    [XmlElement("OriginCountry")]
    public string OriginCountry { get; set; }

    [XmlElement("AdditionalInformation")]
    public string AdditionalInformation { get; set; }

    [XmlElement("BirthPlace")]
    public string BirthPlace { get; set; }

    [XmlElement("RelativeId")]
    public string RelativeId { get; set; }

    [XmlElement("CountryOfActivity")]
    public string CountryOfActivity { get; set; }
}
