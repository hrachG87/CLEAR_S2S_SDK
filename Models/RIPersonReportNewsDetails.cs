using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonReportNewsDetails")]
public class RIPersonReportNewsDetails
{
    [XmlElement("newsRecord")]
    public List<NewsResults> newsRecord { get; set; }

}
}