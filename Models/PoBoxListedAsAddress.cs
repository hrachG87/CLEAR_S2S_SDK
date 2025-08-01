using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PoBoxListedAsAddress")]
public class PoBoxListedAsAddress
{
    [XmlElement("PoBoxListedAsAddressIndicator")]
    public string PoBoxListedAsAddressIndicator { get; set; }

    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("PoBoxListedAsAddressDetails")]
    public List<PoBoxListedAsAddressDetails> PoBoxListedAsAddressDetails { get; set; }

}