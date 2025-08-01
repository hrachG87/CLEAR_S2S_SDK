using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("HistoricalAddress")]
public class HistoricalAddress
{
    [XmlElement("HistoricalAddressIndicator")]
    public string HistoricalAddressIndicator { get; set; }

    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }
}
