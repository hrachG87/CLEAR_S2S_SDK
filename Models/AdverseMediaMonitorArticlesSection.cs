using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaMonitorArticlesSection")]
public class AdverseMediaMonitorArticlesSection
{
    [XmlElement("AdverseMediaMonitorArticleRecord")]
    public List<AdverseMediaMonitorArticleRecord> AdverseMediaMonitorArticleRecord { get; set; }

}
}