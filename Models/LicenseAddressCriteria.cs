using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LicenseAddressCriteria")]
public class LicenseAddressCriteria
{
    [XmlElement("StreetNamesSoundSimilarOption")]
    public bool StreetNamesSoundSimilarOption { get; set; }

    [XmlElement("Street")]
    public string Street { get; set; }

    [XmlElement("City")]
    public string City { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

    [XmlElement("County")]
    public string County { get; set; }

    [XmlElement("ZipCode")]
    public string ZipCode { get; set; }

    [XmlElement("Province")]
    public string Province { get; set; }

    [XmlElement("Country")]
    public string Country { get; set; }

    [XmlElement("AddressType")]
    public string AddressType { get; set; }

}
}