using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformWebAnalyticsDetails")]
public class RiskInformWebAnalyticsDetails
{
    [XmlElement("WebAnalyticsRecord")]
    public List<WebResult> WebAnalyticsRecord { get; set; }
}
