using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("QuarterlyScoreTrends")]
public class QuarterlyScoreTrends
{
    [XmlElement("QuarterlyScoreTrend")]
    public List<QuarterlyScoreTrend> QuarterlyScoreTrend { get; set; }
}
