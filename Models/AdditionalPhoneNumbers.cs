using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdditionalPhoneNumbers")]
public class AdditionalPhoneNumbers
{
    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("SourceInfo")]
    public List<SearchSources> SourceInfo { get; set; }

    [XmlElement("PhoneNumberType")]
    public string PhoneNumberType { get; set; }

}
}