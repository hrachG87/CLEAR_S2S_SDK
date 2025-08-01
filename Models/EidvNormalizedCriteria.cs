using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EidvNormalizedCriteria")]
public class EidvNormalizedCriteria
{
    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("MiddleName")]
    public string MiddleName { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

    [XmlElement("BirthDate")]
    public string BirthDate { get; set; }

    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("DriversLicense")]
    public string DriversLicense { get; set; }

    [XmlElement("Street")]
    public string Street { get; set; }

    [XmlElement("StreetNumber")]
    public string StreetNumber { get; set; }

    [XmlElement("StreetName")]
    public string StreetName { get; set; }

    [XmlElement("City")]
    public string City { get; set; }

    [XmlElement("AlternateCity")]
    public string AlternateCity { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

    [XmlElement("ZipCode")]
    public string ZipCode { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("PhoneCountryCode")]
    public string PhoneCountryCode { get; set; }

    [XmlElement("EmailAddress")]
    public string EmailAddress { get; set; }

    [XmlElement("NPINumber")]
    public string NPINumber { get; set; }

}