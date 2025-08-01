using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SingleSourceTiedToEntity")]
public class SingleSourceTiedToEntity
{
    [XmlElement("SingleSourceTiedToEntityIndicator")]
    public string SingleSourceTiedToEntityIndicator { get; set; }

    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }
}
