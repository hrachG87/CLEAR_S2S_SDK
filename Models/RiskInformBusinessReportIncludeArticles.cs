using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformBusinessReportIncludeArticles")]
public class RiskInformBusinessReportIncludeArticles
{
    [XmlElement("NewsRecord")]
    public RiskInformBusinessReportNewsRecordInfo NewsRecord { get; set; }

    [XmlElement("WebAnalyticsRecord")]
    public RiskInformBusinessReportWebAnalyticsRecordInfo WebAnalyticsRecord { get; set; }
}
