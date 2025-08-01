using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LicenseDataLicenseInfo")]
public class LicenseDataLicenseInfo
{
    [XmlElement("BoardCertification")]
    public string BoardCertification { get; set; }

    [XmlElement("LicenseCertification")]
    public string LicenseCertification { get; set; }

    [XmlElement("LicenseStatus")]
    public string LicenseStatus { get; set; }

    [XmlElement("TypeOfLicense")]
    public List<string> TypeOfLicense { get; set; }

    [XmlElement("LicenseFirstIssueDate")]
    public string LicenseFirstIssueDate { get; set; }

    [XmlElement("LicenseLastIssueDate")]
    public string LicenseLastIssueDate { get; set; }

    [XmlElement("LicenseEffectiveDate")]
    public string LicenseEffectiveDate { get; set; }

    [XmlElement("LicenseExpirationDate")]
    public string LicenseExpirationDate { get; set; }

    [XmlElement("LicenseNumber")]
    public string LicenseNumber { get; set; }

    [XmlElement("LicenseState")]
    public string LicenseState { get; set; }

    [XmlElement("LicenseRestrictionType")]
    public string LicenseRestrictionType { get; set; }

    [XmlElement("ProviderType")]
    public string ProviderType { get; set; }

    [XmlElement("ProviderClass")]
    public string ProviderClass { get; set; }

    [XmlElement("ProviderSpecialty")]
    public string ProviderSpecialty { get; set; }

}