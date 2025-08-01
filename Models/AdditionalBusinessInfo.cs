using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdditionalBusinessInfo")]
public class AdditionalBusinessInfo
{
    [XmlElement("HeadquartersName")]
    public string HeadquartersName { get; set; }

    [XmlElement("GlobalUltimateName")]
    public string GlobalUltimateName { get; set; }

    [XmlElement("BusinessLegalStatusCode")]
    public string BusinessLegalStatusCode { get; set; }

    [XmlElement("YearEstablished")]
    public string YearEstablished { get; set; }

    [XmlElement("TaxIdType")]
    public string TaxIdType { get; set; }

    [XmlElement("TaxIdNumber")]
    public string TaxIdNumber { get; set; }

    [XmlElement("StockExchangeCode")]
    public string StockExchangeCode { get; set; }

    [XmlElement("StockTickerSymbol")]
    public string StockTickerSymbol { get; set; }

    [XmlElement("GovernmentEntity")]
    public string GovernmentEntity { get; set; }

    [XmlElement("NonProfitEntity")]
    public string NonProfitEntity { get; set; }

    [XmlElement("OutOfBusinessIndicator")]
    public string OutOfBusinessIndicator { get; set; }

    [XmlElement("ActualNumberEmployees")]
    public string ActualNumberEmployees { get; set; }

    [XmlElement("TotalSales")]
    public string TotalSales { get; set; }

    [XmlElement("RecordUpdateDate")]
    public string RecordUpdateDate { get; set; }

    [XmlElement("CorporateFilingNumber")]
    public string CorporateFilingNumber { get; set; }

    [XmlElement("UKHouseNumber")]
    public string UKHouseNumber { get; set; }

}
}