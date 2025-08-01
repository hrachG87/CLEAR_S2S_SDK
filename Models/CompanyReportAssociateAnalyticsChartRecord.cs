using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportAssociateAnalyticsChartRecord")]
public class CompanyReportAssociateAnalyticsChartRecord
{
    [XmlElement("Associates")]
    public List<CompanyReportChartDetails> Associates { get; set; }

    [XmlElement("AssociatesWithEntityId")]
    public List<CompanyReportChartDetailsWithEntityId> AssociatesWithEntityId { get; set; }

}
}