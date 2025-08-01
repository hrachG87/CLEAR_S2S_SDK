using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskDashboardSection")]
public class RiskDashboardSection
{
    [XmlElement("RiskDashboardRecord")]
    public List<RiskDashboardRecord> RiskDashboardRecord { get; set; }

}
}