using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIPersonReportWebAnalyticsDetails")]
public class RIPersonReportWebAnalyticsDetails
{
    [XmlElement("WebAnalyticsRecord")]
    public RIPersonReportWebAnalyticsRecord WebAnalyticsRecord { get; set; }

}