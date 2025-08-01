using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PhoneRecord")]
public class PhoneRecord
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("PhoneType")]
    public string PhoneType { get; set; }

    [XmlElement("DirectIndialNumber")]
    public string DirectIndialNumber { get; set; }

    [XmlElement("RecordType")]
    public string RecordType { get; set; }

    [XmlElement("FirstReportedDate")]
    public string FirstReportedDate { get; set; }

    [XmlElement("LastReportedDate")]
    public string LastReportedDate { get; set; }

    [XmlElement("OriginalServiceProvider")]
    public string OriginalServiceProvider { get; set; }

    [XmlElement("ListedInDirectoryAssist")]
    public string ListedInDirectoryAssist { get; set; }

    [XmlElement("PhoneConfidenceScore")]
    public string PhoneConfidenceScore { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("MailDeliverable")]
    public string MailDeliverable { get; set; }

    [XmlElement("AddressValidationDate")]
    public string AddressValidationDate { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}