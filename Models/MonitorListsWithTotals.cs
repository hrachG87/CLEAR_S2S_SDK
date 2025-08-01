using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MonitorListsWithTotals")]
public class MonitorListsWithTotals
{
    [XmlElement("MonitorListWithTotals")]
    public List<MonitorListWithTotals> MonitorListWithTotals { get; set; }

}
}