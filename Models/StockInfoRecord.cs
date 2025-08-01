using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("StockInfoRecord")]
public class StockInfoRecord
{
    [XmlElement("NoParShares")]
    public string NoParShares { get; set; }

    [XmlElement("StockAmendmentNum")]
    public string StockAmendmentNum { get; set; }

    [XmlElement("StockBeginDate")]
    public string StockBeginDate { get; set; }

    [XmlElement("StockDetail")]
    public List<StockDetail> StockDetail { get; set; }

    [XmlElement("TotalAuthorizedShares")]
    public string TotalAuthorizedShares { get; set; }

}