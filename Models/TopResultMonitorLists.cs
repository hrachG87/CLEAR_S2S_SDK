using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("TopResultMonitorLists")]
public class TopResultMonitorLists
{
    [XmlElement("TopResultMonitorList")]
    public List<TopResultMonitorList> TopResultMonitorList { get; set; }

}
}