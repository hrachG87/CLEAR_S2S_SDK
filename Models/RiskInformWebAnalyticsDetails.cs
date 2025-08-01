using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformWebAnalyticsDetails")]
public class RiskInformWebAnalyticsDetails
{
    [XmlElement("WebAnalyticsRecord")]
    public List<WebResult> WebAnalyticsRecord { get; set; }

}
}