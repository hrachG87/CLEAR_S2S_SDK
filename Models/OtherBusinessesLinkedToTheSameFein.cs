using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OtherBusinessesLinkedToTheSameFein")]
public class OtherBusinessesLinkedToTheSameFein
{
    [XmlElement("OtherBusinessesLinkedToTheSameFeinIndicator")]
    public string OtherBusinessesLinkedToTheSameFeinIndicator { get; set; }

    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("OtherBusinessesLinkedToTheSameFeinDetails")]
    public List<OtherBusinessesLinkedToTheSameFeinDetails> OtherBusinessesLinkedToTheSameFeinDetails { get; set; }

}