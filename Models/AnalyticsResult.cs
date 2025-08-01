using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AnalyticsResult")]
public class AnalyticsResult
{
    [XmlElement("TotalMonitorLists")]
    public int TotalMonitorLists { get; set; }

    [XmlElement("TotalAlertSubjects")]
    public int TotalAlertSubjects { get; set; }

    [XmlElement("TotalAlerts")]
    public int TotalAlerts { get; set; }

    [XmlElement("AverageRelevance")]
    public double AverageRelevance { get; set; }

    [XmlElement("TopResultCategories")]
    public TopResultCategories TopResultCategories { get; set; }

    [XmlElement("TopResultAlertSubjects")]
    public TopResultAlertSubjects TopResultAlertSubjects { get; set; }

    [XmlElement("TopResultMonitorLists")]
    public TopResultMonitorLists TopResultMonitorLists { get; set; }

    [XmlElement("MonitorListsWithTotals")]
    public MonitorListsWithTotals MonitorListsWithTotals { get; set; }

}
}