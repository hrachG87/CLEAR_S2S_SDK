using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIPersonSearchWebAnalytics")]
public class RIPersonSearchWebAnalytics
{
    [XmlElement("PeopleWebAnalyticsResult")]
    public List<RIPersonSearchPeopleWebAnalyticsResult> PeopleWebAnalyticsResult { get; set; }

    [XmlElement("WebResult")]
    public List<RiskInformPersonWebResult> WebResult { get; set; }

}