using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyReportAssociateAnalyticsChartSection")]
public class CompanyReportAssociateAnalyticsChartSection
{
    [XmlElement("AssociateAnalyticsChartRecord")]
    public List<CompanyReportAssociateAnalyticsChartRecord> AssociateAnalyticsChartRecord { get; set; }
}
