using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonCriteria")]
public class PersonCriteria
{
    [XmlElement("NameInfo")]
    public PersonNameCriteria NameInfo { get; set; }

    [XmlElement("AddressInfo")]
    public PersonAddressCriteria AddressInfo { get; set; }

    [XmlElement("EmailAddress")]
    public string EmailAddress { get; set; }

    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("AgeInfo")]
    public AgeCriteria AgeInfo { get; set; }

    [XmlElement("DriverLicenseNumber")]
    public string DriverLicenseNumber { get; set; }

    [XmlElement("PersonEntityId")]
    public string PersonEntityId { get; set; }

    [XmlElement("WorldCheckUniqueId")]
    public string WorldCheckUniqueId { get; set; }

    [XmlElement("NPINumber")]
    public string NPINumber { get; set; }
}
