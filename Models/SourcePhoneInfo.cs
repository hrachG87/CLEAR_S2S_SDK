using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SourcePhoneInfo")]
public class SourcePhoneInfo
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("BusinessContact")]
    public string BusinessContact { get; set; }

    [XmlElement("OfficerName")]
    public string OfficerName { get; set; }

    [XmlElement("ContactForLocation")]
    public string ContactForLocation { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

}
}