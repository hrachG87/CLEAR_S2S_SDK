using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ObituariesNewsSection")]
public class ObituariesNewsSection
{
    [XmlElement("ObituariesNewsRecord")]
    public List<NewsResults> ObituariesNewsRecord { get; set; }
}
