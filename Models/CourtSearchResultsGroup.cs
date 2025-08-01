using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CourtSearchResultsGroup")]
public class CourtSearchResultsGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("DominantValues")]
    public CourtDominantValuesContainer DominantValues { get; set; }

    [XmlElement("RecordDetails")]
    public CourtRecordDetailsContainer RecordDetails { get; set; }

}