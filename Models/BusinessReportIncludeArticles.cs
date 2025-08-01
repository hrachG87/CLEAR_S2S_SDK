using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessReportIncludeArticles")]
public class BusinessReportIncludeArticles
{
    [XmlElement("NewsRecord")]
    public BusinessReportNewsRecord NewsRecord { get; set; }

    [XmlElement("WebAnalyticsRecord")]
    public Business WebAnalyticsRecord { get; set; }

}