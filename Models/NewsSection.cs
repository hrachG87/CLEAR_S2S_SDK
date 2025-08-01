using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("NewsSection")]
public class NewsSection
{
    [XmlElement("NewsRecord")]
    public List<NewsResults> NewsRecord { get; set; }
}
