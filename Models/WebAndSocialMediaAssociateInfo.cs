using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WebAndSocialMediaAssociateInfo")]
public class WebAndSocialMediaAssociateInfo
{
    [XmlElement("NameInfo")]
    public WebAndSocialMediaNameInfo NameInfo { get; set; }

    [XmlElement("Type")]
    public string Type { get; set; }

    [XmlElement("ValidSince")]
    public string ValidSince { get; set; }

}
}