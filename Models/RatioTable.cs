using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RatioTable")]
public class RatioTable
{
    [XmlElement("ReturnOnSales")]
    public string ReturnOnSales { get; set; }

    [XmlElement("CurrentRatio")]
    public string CurrentRatio { get; set; }

    [XmlElement("AssetsSales")]
    public string AssetsSales { get; set; }

    [XmlElement("TotalLiabilityNetWorth")]
    public string TotalLiabilityNetWorth { get; set; }

    [XmlElement("ReturnOnNetWorth")]
    public string ReturnOnNetWorth { get; set; }

    [XmlElement("QuickRatio")]
    public string QuickRatio { get; set; }

    [XmlElement("SalesNetWorkingCapitol")]
    public string SalesNetWorkingCapitol { get; set; }

}
}