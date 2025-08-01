using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DECorpReportSections")]
public class DECorpReportSections
{
    [XmlElement("GeneralSection")]
    public GeneralSection GeneralSection { get; set; }

    [XmlElement("TaxSection")]
    public TaxSection TaxSection { get; set; }

    [XmlElement("FilingHistorySection")]
    public FilingHistorySection FilingHistorySection { get; set; }

    [XmlElement("StockSection")]
    public StockSection StockSection { get; set; }

    [XmlElement("RegisteredAgentSection")]
    public RegisteredAgentSection RegisteredAgentSection { get; set; }

    [XmlElement("BankruptcySection")]
    public DECorpBankruptcySection BankruptcySection { get; set; }

}
}