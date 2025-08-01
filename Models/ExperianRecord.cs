using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ExperianRecord")]
public class ExperianRecord
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("SpouseName")]
    public string SpouseName { get; set; }

    [XmlElement("AddressesPhones")]
    public List<AddressesPhones> AddressesPhones { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("AKANameInfo")]
    public List<AKANameInfo> AKANameInfo { get; set; }

}
}