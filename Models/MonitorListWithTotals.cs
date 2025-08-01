using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MonitorListWithTotals")]
public class MonitorListWithTotals
{
    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("TotalAlertSubjects")]
    public int TotalAlertSubjects { get; set; }

}
}