using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonSearchAddressInfo")]
public class PersonSearchAddressInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Phones")]
    public PhoneInfo Phones { get; set; }

    [XmlElement("SourceInfo")]
    public List<PersonSearchSources> SourceInfo { get; set; }

}
}