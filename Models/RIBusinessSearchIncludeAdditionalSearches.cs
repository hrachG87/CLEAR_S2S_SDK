using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIBusinessSearchIncludeAdditionalSearches")]
public class RIBusinessSearchIncludeAdditionalSearches
{
    [XmlElement("WebAnalyticsSearch")]
    public bool WebAnalyticsSearch { get; set; }

}
}