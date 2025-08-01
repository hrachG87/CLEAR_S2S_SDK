using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MonitorListWithTotals")]
public class MonitorListWithTotals
{
    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("TotalAlertSubjects")]
    public int TotalAlertSubjects { get; set; }
}
