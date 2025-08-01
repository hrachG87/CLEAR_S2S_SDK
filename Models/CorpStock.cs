using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CorpStock")]
public class CorpStock
{
    [XmlElement("AuthShares")]
    public string AuthShares { get; set; }

    [XmlElement("ConvertStock")]
    public string ConvertStock { get; set; }

    [XmlElement("ParValue")]
    public string ParValue { get; set; }

    [XmlElement("ParValueIndicator")]
    public string ParValueIndicator { get; set; }

    [XmlElement("StockClass")]
    public List<string> StockClass { get; set; }

    [XmlElement("StockIssued")]
    public string StockIssued { get; set; }

    [XmlElement("TotalValue")]
    public string TotalValue { get; set; }

    [XmlElement("VotingRights")]
    public string VotingRights { get; set; }

}