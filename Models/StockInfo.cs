using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("StockInfo")]
public class StockInfo
{
    [XmlElement("TickerSymbol")]
    public string TickerSymbol { get; set; }

    [XmlElement("Exchanges")]
    public string Exchanges { get; set; }

}
}