using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportIncludeArticles")]
public class PersonReportIncludeArticles
{
    [XmlElement("NewsRecord")]
    public PersonReportNewsRecord NewsRecord { get; set; }

    [XmlElement("WebAnalyticsRecord")]
    public PersonReportWebAnalyticsRecord WebAnalyticsRecord { get; set; }

}