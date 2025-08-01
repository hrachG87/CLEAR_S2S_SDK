using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PhoneSearchResultsGroup")]
public class PhoneSearchResultsGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("DominantValues")]
    public PhoneDominantValuesContainer DominantValues { get; set; }

    [XmlElement("RecordDetails")]
    public PhoneRecordDetailsContainer RecordDetails { get; set; }

}