using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DriverLicenseRecord")]
public class DriverLicenseRecord
{
    [XmlElement("DPPA")]
    public List<string> DPPA { get; set; }

    [XmlElement("LicenseIssueInfo")]
    public LicenseIssueInfo LicenseIssueInfo { get; set; }

    [XmlElement("MailingAddress")]
    public CommonDataAddress MailingAddress { get; set; }

    [XmlElement("PersonInfo")]
    public LicensePersonInfo PersonInfo { get; set; }

    [XmlElement("PhysicalAddress")]
    public CommonDataAddress PhysicalAddress { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}
}