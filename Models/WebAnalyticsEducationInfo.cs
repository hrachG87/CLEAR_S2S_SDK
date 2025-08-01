using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WebAnalyticsEducationInfo")]
public class WebAnalyticsEducationInfo
{
    [XmlElement("Education")]
    public List<string> Education { get; set; }

}
}