using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("HealthcareLicenseRecord")]
public class HealthcareLicenseRecord
{
    [XmlElement("PersonInfo")]
    public LicensePersonInfo PersonInfo { get; set; }

    [XmlElement("BusinessInfo")]
    public LicenseDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("Email")]
    public string Email { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("OtherAddress")]
    public CommonDataAddress OtherAddress { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("LastReportedDate")]
    public string LastReportedDate { get; set; }

    [XmlElement("AdditionalInfo")]
    public string AdditionalInfo { get; set; }

    [XmlElement("PublicationInfo")]
    public LicensePublicationInfo PublicationInfo { get; set; }

    [XmlElement("LicenseInfo")]
    public List<LicenseDataLicenseInfo> LicenseInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
