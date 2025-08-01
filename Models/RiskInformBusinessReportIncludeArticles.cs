using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformBusinessReportIncludeArticles")]
public class RiskInformBusinessReportIncludeArticles
{
    [XmlElement("NewsRecord")]
    public RiskInformBusinessReportNewsRecordInfo NewsRecord { get; set; }

    [XmlElement("WebAnalyticsRecord")]
    public RiskInformBusinessReportWebAnalyticsRecordInfo WebAnalyticsRecord { get; set; }

}
}