using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaArticleCategorySection")]
public class AdverseMediaArticleCategorySection
{
    [XmlElement("AdverseMediaMonitorArticleRecord")]
    public List<AdverseMediaMonitorArticleRecord> AdverseMediaMonitorArticleRecord { get; set; }
}
