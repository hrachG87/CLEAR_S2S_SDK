using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonSearchIncludeAdditionalSearches")]
public class RIPersonSearchIncludeAdditionalSearches
{
    [XmlElement("WebAnalyticsSearch")]
    public bool WebAnalyticsSearch { get; set; }

}
}