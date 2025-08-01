using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("VehicleSearchResultsGroup")]
public class VehicleSearchResultsGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("DominantValues")]
    public VehicleDominantValuesContainer DominantValues { get; set; }

    [XmlElement("RecordDetails")]
    public VehicleRecordDetailsContainer RecordDetails { get; set; }
}
