using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OperatingCompany")]
public class OperatingCompany
{
    [XmlElement("CompanyName")]
    public string CompanyName { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("AffiliatedTo")]
    public string AffiliatedTo { get; set; }

    [XmlElement("CompanyNumber")]
    public string CompanyNumber { get; set; }

    [XmlElement("CompanyContactInfo")]
    public PeopleDataContactInfo CompanyContactInfo { get; set; }

}
}