using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WebAndSocialMediaCriteria")]
public class WebAndSocialMediaCriteria
{
    [XmlElement("WebAndSocialSearchMediaCriteria")]
    public WebAndSocialMediaSearchCriteria WebAndSocialSearchMediaCriteria { get; set; }

}
}