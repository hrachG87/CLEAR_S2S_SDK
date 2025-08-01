using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("TrusteeInfo")]
public class TrusteeInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("TrusteeSalesNumber")]
    public string TrusteeSalesNumber { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

}
}