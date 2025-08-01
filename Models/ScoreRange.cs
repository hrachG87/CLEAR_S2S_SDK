using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ScoreRange")]
public class ScoreRange
{
    [XmlElement("MinRelevance")]
    public string MinRelevance { get; set; }

    [XmlElement("MaxRelevance")]
    public string MaxRelevance { get; set; }
}
