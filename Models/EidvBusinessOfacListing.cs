using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EidvBusinessOfacListing")]
public class EidvBusinessOfacListing
{
    [XmlElement("OfacListingIndicator")]
    public string OfacListingIndicator { get; set; }

    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("OfacListingDetails")]
    public List<EidvBusinessOfacListingDetails> OfacListingDetails { get; set; }
}
