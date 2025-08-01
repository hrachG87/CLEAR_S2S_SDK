using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Death")]
public class Death
{
    [XmlElement("DeathIndicator")]
    public string DeathIndicator { get; set; }

    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("DeathDetails")]
    public List<DeathDetails> DeathDetails { get; set; }
}
