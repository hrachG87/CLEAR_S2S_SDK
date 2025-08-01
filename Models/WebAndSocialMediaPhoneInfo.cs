using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WebAndSocialMediaPhoneInfo")]
public class WebAndSocialMediaPhoneInfo
{
    [XmlElement("Type")]
    public string Type { get; set; }

    [XmlElement("Number")]
    public string Number { get; set; }

    [XmlElement("CountryCode")]
    public string CountryCode { get; set; }

    [XmlElement("ValidSinceDate")]
    public string ValidSinceDate { get; set; }

    [XmlElement("LastSeenDate")]
    public string LastSeenDate { get; set; }

}
}