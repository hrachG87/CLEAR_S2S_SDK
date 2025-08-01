using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("StockSection")]
public class StockSection
{
    [XmlElement("StockInfoRecord")]
    public List<StockInfoRecord> StockInfoRecord { get; set; }

}