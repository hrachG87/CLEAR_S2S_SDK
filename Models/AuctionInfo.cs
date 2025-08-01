using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AuctionInfo")]
public class AuctionInfo
{
    [XmlElement("AuctionBid")]
    public string AuctionBid { get; set; }

    [XmlElement("AuctionDate")]
    public string AuctionDate { get; set; }

    [XmlElement("AuctionTime")]
    public string AuctionTime { get; set; }

}
}