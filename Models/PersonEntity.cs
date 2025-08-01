using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonEntity")]
public class PersonEntity
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("TotalScore")]
    public string TotalScore { get; set; }

    [XmlElement("MinThresholdScore")]
    public string MinThresholdScore { get; set; }

    [XmlElement("EntityId")]
    public string EntityId { get; set; }

    [XmlElement("Header")]
    public RiskInformPersonSearchHeader Header { get; set; }

    [XmlElement("Sections")]
    public RIPersonSearchSections Sections { get; set; }

}