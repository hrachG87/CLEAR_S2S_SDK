using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("NewsMediaDetailsSection")]
public class NewsMediaDetailsSection
{
    [XmlElement("NewsMediaDetailsRecord")]
    public List<WebAndSocialMediaRecord> NewsMediaDetailsRecord { get; set; }
}
