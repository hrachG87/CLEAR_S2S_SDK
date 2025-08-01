using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaResultGroup")]
public class AdverseMediaResultGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("RecordDetails")]
    public AdverseMediaRecordDetails RecordDetails { get; set; }
}
