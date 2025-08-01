using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonAssociateAnalyticsResponseDetail")]
public class PersonAssociateAnalyticsResponseDetail
{
    [XmlElement("AssociatesWithEntityId")]
    public List<FlagSearchChartDetailsWithEntityId> AssociatesWithEntityId { get; set; }

    [XmlElement("RelativeWithEntityId")]
    public List<FlagSearchChartDetailsWithEntityId> RelativeWithEntityId { get; set; }

}
}