using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("NewsSummaryResultsGroup")]
public class NewsSummaryResultsGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("recordDetails")]
    public NewsSummaryRecordDetails recordDetails { get; set; }

}