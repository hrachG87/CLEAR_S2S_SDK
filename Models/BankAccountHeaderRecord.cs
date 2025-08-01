using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BankAccountHeaderRecord")]
public class BankAccountHeaderRecord
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("PersonBirthDate")]
    public string PersonBirthDate { get; set; }

    [XmlElement("BankHeaderLicenseInfo")]
    public List<BankHeaderLicenseInfo> BankHeaderLicenseInfo { get; set; }

    [XmlElement("Address")]
    public List<CommonDataAddress> Address { get; set; }

    [XmlElement("PhoneNumber")]
    public List<string> PhoneNumber { get; set; }

    [XmlElement("LastReportedDate")]
    public string LastReportedDate { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("AKAName")]
    public List<PersonName> AKAName { get; set; }

}
}