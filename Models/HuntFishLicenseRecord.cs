using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("HuntFishLicenseRecord")]
public class HuntFishLicenseRecord
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("HuntFishPermit")]
    public List<PermitInfo> HuntFishPermit { get; set; }

    [XmlElement("MailingAddress")]
    public CommonDataAddress MailingAddress { get; set; }

    [XmlElement("PersonInfo")]
    public LicensePersonInfo PersonInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
