using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AddressesPhones")]
public class AddressesPhones
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("PhoneNumber1")]
    public string PhoneNumber1 { get; set; }

    [XmlElement("PhoneNumber2")]
    public string PhoneNumber2 { get; set; }

    [XmlElement("FirstReportedDate")]
    public string FirstReportedDate { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }

    [XmlElement("Latitude")]
    public string Latitude { get; set; }

    [XmlElement("Longitude")]
    public string Longitude { get; set; }

    [XmlElement("AddressType")]
    public string AddressType { get; set; }

    [XmlElement("County")]
    public string County { get; set; }

}
}