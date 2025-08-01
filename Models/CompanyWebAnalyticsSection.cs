using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyWebAnalyticsSection")]
public class CompanyWebAnalyticsSection
{
    [XmlElement("PeopleWebAnalyticsResult")]
    public List<PeopleWebAnalyticsResult> PeopleWebAnalyticsResult { get; set; }

    [XmlElement("PeopleWebAnalyticsRecord")]
    public List<PeopleWebAnalyticsDetails> PeopleWebAnalyticsRecord { get; set; }

    [XmlElement("WebRecord")]
    public List<WebResult> WebRecord { get; set; }

}