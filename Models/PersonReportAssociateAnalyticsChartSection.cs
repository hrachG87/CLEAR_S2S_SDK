using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportAssociateAnalyticsChartSection")]
public class PersonReportAssociateAnalyticsChartSection
{
    [XmlElement("AssociateAnalyticsChartRecord")]
    public List<PersonReportAssociateAnalyticsChartRecord> AssociateAnalyticsChartRecord { get; set; }

}