using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("NewsResultsGroup")]
public class NewsResultsGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("recordDetails")]
    public NewsRecordDetails recordDetails { get; set; }

}