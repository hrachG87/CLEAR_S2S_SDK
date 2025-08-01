using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaMonitorUserTermRecord")]
public class AdverseMediaMonitorUserTermRecord
{
    [XmlElement("Keywords")]
    public string Keywords { get; set; }

    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("DateRange")]
    public DateRange DateRange { get; set; }

    [XmlElement("ScoreRange")]
    public ScoreRange ScoreRange { get; set; }

    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("ArticleTags")]
    public ArticleTags ArticleTags { get; set; }

    [XmlElement("AdverseMediaSanctions")]
    public AdverseMediaSanctions AdverseMediaSanctions { get; set; }

}
}