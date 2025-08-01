using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("LicenseIssueInfo")]
public class LicenseIssueInfo
{
    [XmlElement("DriverLicense")]
    public List<DriverLicenseInfo> DriverLicense { get; set; }

    [XmlElement("DriverLicenseDetails")]
    public List<DriverLicenseDetails> DriverLicenseDetails { get; set; }

    [XmlElement("PersonalID")]
    public string PersonalID { get; set; }

    [XmlElement("PreviousDriverLicense")]
    public List<DriverLicenseInfo> PreviousDriverLicense { get; set; }
}
