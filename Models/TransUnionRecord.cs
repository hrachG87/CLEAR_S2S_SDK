using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("TransUnionRecord")]
public class TransUnionRecord
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("NameFirstReported")]
    public string NameFirstReported { get; set; }

    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("PersonBirthDate")]
    public string PersonBirthDate { get; set; }

    [XmlElement("PersonAge")]
    public string PersonAge { get; set; }

    [XmlElement("HistoricPhoneNumber")]
    public string HistoricPhoneNumber { get; set; }

    [XmlElement("AddressesPhones")]
    public List<AddressesPhones> AddressesPhones { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("AKAName")]
    public PersonName AKAName { get; set; }

}
}