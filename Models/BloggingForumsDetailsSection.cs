using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BloggingForumsDetailsSection")]
public class BloggingForumsDetailsSection
{
    [XmlElement("BloggingForumsDetailsRecord")]
    public List<WebAndSocialMediaRecord> BloggingForumsDetailsRecord { get; set; }
}
