using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RealPropertySearchResultsGroup")]
public class RealPropertySearchResultsGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("DominantValues")]
    public RealPropertyDominantValuesContainer DominantValues { get; set; }

    [XmlElement("RecordDetails")]
    public RealPropertyRecordDetailsContainer RecordDetails { get; set; }

}
}