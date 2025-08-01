using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FinancialInformation")]
public class FinancialInformation
{
    [XmlElement("NetWorthUS")]
    public string NetWorthUS { get; set; }

    [XmlElement("ProfitUS")]
    public string ProfitUS { get; set; }

    [XmlElement("NetWorthLocal")]
    public string NetWorthLocal { get; set; }

    [XmlElement("ProfitLocal")]
    public string ProfitLocal { get; set; }

    [XmlElement("Currency")]
    public string Currency { get; set; }

    [XmlElement("CurrencyConversionDate")]
    public string CurrencyConversionDate { get; set; }

    [XmlElement("ExchangeRate")]
    public string ExchangeRate { get; set; }

}