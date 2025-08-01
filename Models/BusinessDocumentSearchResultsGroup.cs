using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessDocumentSearchResultsGroup")]
public class BusinessDocumentSearchResultsGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("DominantValues")]
    public DominantValues DominantValues { get; set; }

    [XmlElement("RecordDetails")]
    public BusinessDocumentResponseDetails RecordDetails { get; set; }
}
