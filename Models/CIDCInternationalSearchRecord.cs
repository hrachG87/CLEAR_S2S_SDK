using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CIDCInternationalSearchRecord")]
public class CIDCInternationalSearchRecord
{
    [XmlElement("ContentSource")]
    public string ContentSource { get; set; }

    [XmlElement("ContentScore")]
    public string ContentScore { get; set; }

    [XmlElement("CompleteName")]
    public EidvPersonSearchMatchTypeField CompleteName { get; set; }

    [XmlElement("FirstName")]
    public EidvPersonSearchMatchTypeField FirstName { get; set; }

    [XmlElement("MiddleName")]
    public EidvPersonSearchMatchTypeField MiddleName { get; set; }

    [XmlElement("LastName")]
    public EidvPersonSearchMatchTypeField LastName { get; set; }

    [XmlElement("BirthDate")]
    public EidvPersonSearchMatchTypeField BirthDate { get; set; }

    [XmlElement("NationalID")]
    public EidvPersonSearchMatchTypeField NationalID { get; set; }

    [XmlElement("Street")]
    public EidvPersonSearchMatchTypeField Street { get; set; }

    [XmlElement("HouseNumber")]
    public EidvPersonSearchMatchTypeField HouseNumber { get; set; }

    [XmlElement("StreetName")]
    public EidvPersonSearchMatchTypeField StreetName { get; set; }

    [XmlElement("UnitNumber")]
    public EidvPersonSearchMatchTypeField UnitNumber { get; set; }

    [XmlElement("Locality")]
    public EidvPersonSearchMatchTypeField Locality { get; set; }

    [XmlElement("AdministrativeArea")]
    public EidvPersonSearchMatchTypeField AdministrativeArea { get; set; }

    [XmlElement("Country")]
    public EidvPersonSearchMatchTypeField Country { get; set; }

    [XmlElement("PostalCode")]
    public EidvPersonSearchMatchTypeField PostalCode { get; set; }

    [XmlElement("PhoneNumber")]
    public EidvPersonSearchMatchTypeField PhoneNumber { get; set; }

    [XmlElement("EmailAddress")]
    public EidvPersonSearchMatchTypeField EmailAddress { get; set; }

}