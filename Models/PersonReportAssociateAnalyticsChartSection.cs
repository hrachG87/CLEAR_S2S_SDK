using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportAssociateAnalyticsChartSection")]
public class PersonReportAssociateAnalyticsChartSection
{
    [XmlElement("AssociateAnalyticsChartRecord")]
    public List<PersonReportAssociateAnalyticsChartRecord> AssociateAnalyticsChartRecord { get; set; }

}
}