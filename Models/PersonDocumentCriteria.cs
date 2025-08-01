using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonDocumentCriteria")]
public class PersonDocumentCriteria
{
    [XmlElement("PersonName")]
    public PersonDocumentNameCriteria PersonName { get; set; }

    [XmlElement("Address")]
    public PersonDocumentAddressCriteria Address { get; set; }

    [XmlElement("EmailAddress")]
    public string EmailAddress { get; set; }

    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("PersonBirthDate")]
    public string PersonBirthDate { get; set; }

    [XmlElement("DriverLicenseNumber")]
    public string DriverLicenseNumber { get; set; }

    [XmlElement("DocGuid")]
    public string DocGuid { get; set; }

    [XmlElement("NPINumber")]
    public string NPINumber { get; set; }

}
}