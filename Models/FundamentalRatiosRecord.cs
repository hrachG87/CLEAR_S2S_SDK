using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("FundamentalRatiosRecord")]
public class FundamentalRatiosRecord
{
    [XmlElement("PriceAndVolume")]
    public TableLayout PriceAndVolume { get; set; }

    [XmlElement("PerShareData")]
    public TableLayout PerShareData { get; set; }

    [XmlElement("Valuation")]
    public TableLayout Valuation { get; set; }

    [XmlElement("FinancialStrength")]
    public TableLayout FinancialStrength { get; set; }

    [XmlElement("IncomeStatement")]
    public TableLayout IncomeStatement { get; set; }

    [XmlElement("Margins")]
    public TableLayout Margins { get; set; }

    [XmlElement("ManagementEffectiveness")]
    public TableLayout ManagementEffectiveness { get; set; }

    [XmlElement("GrowthRates")]
    public TableLayout GrowthRates { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }
}
