using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaArticlesSection")]
public class AdverseMediaArticlesSection
{
    [XmlElement("AdverseMediaArticleRecord")]
    public List<AdverseMediaArticleRecord> AdverseMediaArticleRecord { get; set; }
}
