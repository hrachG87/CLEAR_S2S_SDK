using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportAddressInfo")]
public class PersonReportAddressInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Phone")]
    public List<PhoneInfo> Phone { get; set; }

    [XmlElement("SourceInfo")]
    public List<SourceInfo> SourceInfo { get; set; }

    [XmlElement("PersonName")]
    public List<PersonName> PersonName { get; set; }

}
}