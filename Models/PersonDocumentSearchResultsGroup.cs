using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonDocumentSearchResultsGroup")]
public class PersonDocumentSearchResultsGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("DominantValues")]
    public PersonDocumentDominantValuesContainer DominantValues { get; set; }

    [XmlElement("RecordDetails")]
    public PersonDocumentRecordDetailsContainer RecordDetails { get; set; }
}
