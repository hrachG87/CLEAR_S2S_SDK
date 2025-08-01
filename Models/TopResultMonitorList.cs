using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("TopResultMonitorList")]
public class TopResultMonitorList
{
    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("ResultCount")]
    public int ResultCount { get; set; }

}
}