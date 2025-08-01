using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LicenseCriteria")]
public class LicenseCriteria
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("PersonName")]
    public LicenseNameCriteria PersonName { get; set; }

    [XmlElement("Address")]
    public LicenseAddressCriteria Address { get; set; }

    [XmlElement("PersonBirthDate")]
    public string PersonBirthDate { get; set; }

    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("DriversLicenseNumber")]
    public string DriversLicenseNumber { get; set; }

    [XmlElement("Profession")]
    public string Profession { get; set; }

    [XmlElement("ProfessionalLicenseNumber")]
    public string ProfessionalLicenseNumber { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("DocGuid")]
    public string DocGuid { get; set; }

    [XmlElement("NPINumber")]
    public string NPINumber { get; set; }

}
}