using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPersonReportIncludeArticles")]
public class RiskInformPersonReportIncludeArticles
{
    [XmlElement("NewsRecord")]
    public RiskInformPersonReportNewsRecordInfo NewsRecord { get; set; }

    [XmlElement("WebAnalyticsRecord")]
    public RiskInformPersonReportWebAnalyticsRecordInfo WebAnalyticsRecord { get; set; }

}
}