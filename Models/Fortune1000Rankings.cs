using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Fortune1000Rankings")]
public class Fortune1000Rankings
{
    [XmlElement("Fortune1000Ranking")]
    public List<Fortune1000Ranking> Fortune1000Ranking { get; set; }
}
