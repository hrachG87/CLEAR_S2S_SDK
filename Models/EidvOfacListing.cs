using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EidvOfacListing")]
public class EidvOfacListing
{
    [XmlElement("OfacListingIndicator")]
    public string OfacListingIndicator { get; set; }

    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("OfacListingDetails")]
    public List<EidvOfacListingDetails> OfacListingDetails { get; set; }

}
}