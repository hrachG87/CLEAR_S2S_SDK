using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LicensePersonInfo")]
public class LicensePersonInfo
{
    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("PersonName")]
    public List<PersonName> PersonName { get; set; }

    [XmlElement("FormerName")]
    public List<PersonName> FormerName { get; set; }

    [XmlElement("PersonSSN")]
    public List<SSNInfo> PersonSSN { get; set; }

    [XmlElement("PhoneInfo")]
    public PhoneInfo PhoneInfo { get; set; }

    [XmlElement("PersonEducation")]
    public SchoolInfo PersonEducation { get; set; }

    [XmlElement("Credentials")]
    public string Credentials { get; set; }

}
}