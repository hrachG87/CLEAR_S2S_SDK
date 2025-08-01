using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessSearchResultsGroup")]
public class BusinessSearchResultsGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("DominantValues")]
    public BusinessDominantValuesContainer DominantValues { get; set; }

    [XmlElement("RecordDetails")]
    public BusinessRecordDetailsContainer RecordDetails { get; set; }

}