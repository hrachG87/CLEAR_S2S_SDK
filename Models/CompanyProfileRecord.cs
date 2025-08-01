using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyProfileRecord")]
public class CompanyProfileRecord
{
    [XmlElement("BusinessInfo")]
    public BusinessDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("StockInfo")]
    public StockInfo StockInfo { get; set; }

    [XmlElement("CurrentOutstandingShares")]
    public string CurrentOutstandingShares { get; set; }

    [XmlElement("Shareholders")]
    public string Shareholders { get; set; }

    [XmlElement("FiscalYearEnd")]
    public string FiscalYearEnd { get; set; }

    [XmlElement("LatestAnnualFinancialDate")]
    public string LatestAnnualFinancialDate { get; set; }

    [XmlElement("AuditorInfo")]
    public AuditorInfo AuditorInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

}
}