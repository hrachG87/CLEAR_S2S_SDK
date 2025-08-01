using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportAssociateAnalyticsChartSection")]
public class CompanyReportAssociateAnalyticsChartSection
{
    [XmlElement("AssociateAnalyticsChartRecord")]
    public List<CompanyReportAssociateAnalyticsChartRecord> AssociateAnalyticsChartRecord { get; set; }

}
}