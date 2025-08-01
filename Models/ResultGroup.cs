using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ResultGroup")]
public class ResultGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("DominantValues")]
    public PersonDominantValuesContainer DominantValues { get; set; }

    [XmlElement("RecordDetails")]
    public PersonRecordDetailsContainer RecordDetails { get; set; }
}
