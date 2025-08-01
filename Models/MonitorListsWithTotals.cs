using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MonitorListsWithTotals")]
public class MonitorListsWithTotals
{
    [XmlElement("MonitorListWithTotals")]
    public List<MonitorListWithTotals> MonitorListWithTotals { get; set; }
}
