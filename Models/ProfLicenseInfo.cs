using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ProfLicenseInfo")]
public class ProfLicenseInfo
{
    [XmlElement("BoardCertification")]
    public string BoardCertification { get; set; }

    [XmlElement("CertificationBoard")]
    public string CertificationBoard { get; set; }

    [XmlElement("LicenseAgency")]
    public string LicenseAgency { get; set; }

    [XmlElement("LicenseDescription")]
    public string LicenseDescription { get; set; }

    [XmlElement("LicenseNumber")]
    public List<string> LicenseNumber { get; set; }

    [XmlElement("LicenseSpecialty")]
    public List<string> LicenseSpecialty { get; set; }

    [XmlElement("LicenseState")]
    public string LicenseState { get; set; }

    [XmlElement("LicenseStatus")]
    public List<string> LicenseStatus { get; set; }

    [XmlElement("TypeofLicense")]
    public List<string> TypeofLicense { get; set; }

}
}