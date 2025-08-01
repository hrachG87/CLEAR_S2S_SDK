using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIPersonSearchPeopleWebAnalyticsResult")]
public class RIPersonSearchPeopleWebAnalyticsResult
{
    [XmlElement("RecordId")]
    public string RecordId { get; set; }

    [XmlElement("PeopleWebAnalyticsSummary")]
    public PeopleWebAnalyticsResult PeopleWebAnalyticsSummary { get; set; }

    [XmlElement("PeopleWebAnalyticsDetails")]
    public PeopleWebAnalyticsDetails PeopleWebAnalyticsDetails { get; set; }

}