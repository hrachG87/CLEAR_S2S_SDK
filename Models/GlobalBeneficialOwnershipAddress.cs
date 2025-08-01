using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GlobalBeneficialOwnershipAddress")]
public class GlobalBeneficialOwnershipAddress
{
    [XmlElement("Street")]
    public string Street { get; set; }

    [XmlElement("StreetLine")]
    public List<string> StreetLine { get; set; }

    [XmlElement("StreetLine1")]
    public string StreetLine1 { get; set; }

    [XmlElement("StreetLine2")]
    public string StreetLine2 { get; set; }

    [XmlElement("StreetLine3")]
    public string StreetLine3 { get; set; }

    [XmlElement("CareOf")]
    public string CareOf { get; set; }

    [XmlElement("City")]
    public string City { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

    [XmlElement("StateAbbreviation")]
    public string StateAbbreviation { get; set; }

    [XmlElement("Province")]
    public string Province { get; set; }

    [XmlElement("ZipCode")]
    public string ZipCode { get; set; }

    [XmlElement("ZipCodeExtension")]
    public string ZipCodeExtension { get; set; }

    [XmlElement("County")]
    public string County { get; set; }

    [XmlElement("Country")]
    public string Country { get; set; }

    [XmlElement("Continent")]
    public string Continent { get; set; }

    [XmlElement("Region")]
    public string Region { get; set; }

    [XmlElement("FullAddress")]
    public string FullAddress { get; set; }

    [XmlElement("TypeOfAddress")]
    public string TypeOfAddress { get; set; }

    [XmlElement("AdditionalInfo")]
    public string AdditionalInfo { get; set; }

    [XmlElement("LastVerifiedDate")]
    public string LastVerifiedDate { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }

    [XmlElement("Latitude")]
    public string Latitude { get; set; }

    [XmlElement("Longitude")]
    public string Longitude { get; set; }

    [XmlElement("ResidenceType")]
    public string ResidenceType { get; set; }

    [XmlElement("DeliverableAddress")]
    public string DeliverableAddress { get; set; }

    [XmlElement("MatchToUserSuppliedZipCode")]
    public string MatchToUserSuppliedZipCode { get; set; }

    [XmlElement("MatchToSubjectsZipCode")]
    public string MatchToSubjectsZipCode { get; set; }

    [XmlElement("MatchToSubjectAddress")]
    public bool MatchToSubjectAddress { get; set; }

    [XmlElement("MatchToUserSuppliedCity")]
    public string MatchToUserSuppliedCity { get; set; }

    [XmlElement("MatchToSubjectsCity")]
    public string MatchToSubjectsCity { get; set; }

    [XmlElement("MatchToUserSuppliedState")]
    public string MatchToUserSuppliedState { get; set; }

    [XmlElement("MatchToSubjectsState")]
    public string MatchToSubjectsState { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("FullAddressOriginalLanguage")]
    public string FullAddressOriginalLanguage { get; set; }

    [XmlElement("StreetOriginalLanguage")]
    public string StreetOriginalLanguage { get; set; }

    [XmlElement("CityOriginalLanguage")]
    public string CityOriginalLanguage { get; set; }

    [XmlElement("StateOriginalLanguage")]
    public string StateOriginalLanguage { get; set; }

    [XmlElement("POBox")]
    public string POBox { get; set; }
}
