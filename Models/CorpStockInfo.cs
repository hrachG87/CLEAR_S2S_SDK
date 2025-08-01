using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CorpStockInfo")]
public class CorpStockInfo
{
    [XmlElement("CorpStock")]
    public List<CorpStock> CorpStock { get; set; }

    [XmlElement("StockType")]
    public string StockType { get; set; }

}
}