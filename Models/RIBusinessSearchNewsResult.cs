using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RIBusinessSearchNewsResult")]
public class RIBusinessSearchNewsResult
{
    [XmlElement("RecordId")]
    public string RecordId { get; set; }

    [XmlElement("NewsSummary")]
    public NewsSummary NewsSummary { get; set; }
}
