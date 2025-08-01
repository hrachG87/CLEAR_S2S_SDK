using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("StockDetail")]
public class StockDetail
{
    [XmlElement("AuthorizedShares")]
    public string AuthorizedShares { get; set; }

    [XmlElement("Description")]
    public string Description { get; set; }

    [XmlElement("DesignatedShares")]
    public string DesignatedShares { get; set; }

    [XmlElement("ParValue")]
    public string ParValue { get; set; }

    [XmlElement("SequenceNum")]
    public string SequenceNum { get; set; }

    [XmlElement("StockSeries")]
    public string StockSeries { get; set; }

    [XmlElement("StockClass")]
    public string StockClass { get; set; }

}