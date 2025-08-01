using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyAssociateAnalyticsResponseDetail")]
public class CompanyAssociateAnalyticsResponseDetail
{
    [XmlElement("AssociatesWithEntityId")]
    public List<FlagSearchChartDetailsWithEntityId> AssociatesWithEntityId { get; set; }

}
}