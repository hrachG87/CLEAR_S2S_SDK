using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("NewsSummaryRecordDetails")]
public class NewsSummaryRecordDetails
{
    [XmlElement("RecordId")]
    public string RecordId { get; set; }

    [XmlElement("NewsSummary")]
    public List<NewsSummary> NewsSummary { get; set; }
}
