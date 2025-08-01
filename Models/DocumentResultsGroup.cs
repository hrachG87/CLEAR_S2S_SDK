using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DocumentResultsGroup")]
public class DocumentResultsGroup
{
    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("RecordDetails")]
    public DocumentRecordDetailsContainer RecordDetails { get; set; }

}