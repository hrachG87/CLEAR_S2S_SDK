using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("NewMoverRecord")]
public class NewMoverRecord
{
    [XmlElement("HeadOfHousehold")]
    public PersonName HeadOfHousehold { get; set; }

    [XmlElement("PersonEthnicity")]
    public string PersonEthnicity { get; set; }

    [XmlElement("AgeRange")]
    public string AgeRange { get; set; }

    [XmlElement("Address")]
    public AddressesPhones Address { get; set; }

    [XmlElement("PhoneNumber")]
    public List<string> PhoneNumber { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}
}