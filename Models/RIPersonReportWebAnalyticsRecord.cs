using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonReportWebAnalyticsRecord")]
public class RIPersonReportWebAnalyticsRecord
{
    [XmlElement("PeopleWebAnalyticsDetails")]
    public List<PeopleWebAnalyticsDetails> PeopleWebAnalyticsDetails { get; set; }

    [XmlElement("WebRecord")]
    public List<WebResult> WebRecord { get; set; }

}
}