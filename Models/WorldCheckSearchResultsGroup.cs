using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WorldCheckSearchResultsGroup")]
public class WorldCheckSearchResultsGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("DominantValues")]
    public WorldCheckDocumentDominantValuesContainer DominantValues { get; set; }

    [XmlElement("RecordDetails")]
    public WorldCheckRecordDetails RecordDetails { get; set; }
}
