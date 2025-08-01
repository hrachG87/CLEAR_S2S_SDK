using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CIDCInternationalPersonSearchCriteria")]
public class CIDCInternationalPersonSearchCriteria
{
    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("MiddleName")]
    public string MiddleName { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

    [XmlElement("BirthDate")]
    public BirthDate BirthDate { get; set; }

    [XmlElement("nationalID")]
    public NationalID nationalID { get; set; }

    [XmlElement("HouseNumber")]
    public string HouseNumber { get; set; }

    [XmlElement("UnitNumber")]
    public string UnitNumber { get; set; }

    [XmlElement("StreetName")]
    public string StreetName { get; set; }

    [XmlElement("Locality")]
    public string Locality { get; set; }

    [XmlElement("AdministrativeArea")]
    public string AdministrativeArea { get; set; }

    [XmlElement("PostalCode")]
    public string PostalCode { get; set; }

    [XmlElement("Country")]
    public string Country { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("EmailAddress")]
    public string EmailAddress { get; set; }

}