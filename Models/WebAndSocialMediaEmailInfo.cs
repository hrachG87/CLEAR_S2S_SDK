using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WebAndSocialMediaEmailInfo")]
public class WebAndSocialMediaEmailInfo
{
    [XmlElement("EmailAddress")]
    public string EmailAddress { get; set; }

    [XmlElement("ValidSinceDate")]
    public string ValidSinceDate { get; set; }

}
}