using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("StockSection")]
public class StockSection
{
    [XmlElement("StockInfoRecord")]
    public List<StockInfoRecord> StockInfoRecord { get; set; }

}
}