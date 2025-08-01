using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MarriageSection")]
public class MarriageSection
{
    [XmlElement("marriageRecord")]
    public List<MarriageRecord> marriageRecord { get; set; }
}
