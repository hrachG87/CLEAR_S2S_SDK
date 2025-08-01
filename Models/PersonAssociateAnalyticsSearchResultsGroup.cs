using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonAssociateAnalyticsSearchResultsGroup")]
public class PersonAssociateAnalyticsSearchResultsGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("RecordDetails")]
    public PersonAssociateAnalyticsResponseDetailContainer RecordDetails { get; set; }
}
