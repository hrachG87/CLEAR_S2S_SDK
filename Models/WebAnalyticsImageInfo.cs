using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WebAnalyticsImageInfo")]
public class WebAnalyticsImageInfo
{
    [XmlElement("Image")]
    public string Image { get; set; }

    [XmlElement("Name")]
    public WebAnalyticsNameInfo Name { get; set; }

    [XmlElement("PersonAge")]
    public string PersonAge { get; set; }

}
}