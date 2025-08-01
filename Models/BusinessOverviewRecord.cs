using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessOverviewRecord")]
public class BusinessOverviewRecord
{
    [XmlElement("CompanyName")]
    public string CompanyName { get; set; }

    [XmlElement("Address")]
    public List<CommonDataAddress> Address { get; set; }

    [XmlElement("AlternateCompanyName")]
    public List<string> AlternateCompanyName { get; set; }

    [XmlElement("TickerSymbol")]
    public string TickerSymbol { get; set; }

    [XmlElement("StateofIncorporation.")]
    public List<string> StateofIncorporation. { get; set; }

    [XmlElement("DateofIncorporation")]
    public List<string> DateofIncorporation { get; set; }

    [XmlElement("YearEstablished")]
    public string YearEstablished { get; set; }

    [XmlElement("CorporationStatus")]
    public string CorporationStatus { get; set; }

    [XmlElement("PrimarySICCode")]
    public string PrimarySICCode { get; set; }

    [XmlElement("DUNS")]
    public List<string> DUNS { get; set; }

    [XmlElement("FEIN")]
    public List<string> FEIN { get; set; }

    [XmlElement("CurrentOutstandingShares")]
    public string CurrentOutstandingShares { get; set; }

    [XmlElement("Shareholders")]
    public string Shareholders { get; set; }

    [XmlElement("NumberofEmployees")]
    public string NumberofEmployees { get; set; }

    [XmlElement("FiscalYearEnd")]
    public string FiscalYearEnd { get; set; }

    [XmlElement("LastAnnualFinancialDate")]
    public string LastAnnualFinancialDate { get; set; }

    [XmlElement("RegisteredAgent")]
    public List<string> RegisteredAgent { get; set; }

    [XmlElement("WebAddress")]
    public string WebAddress { get; set; }

    [XmlElement("BusinessDescription")]
    public string BusinessDescription { get; set; }

    [XmlElement("CompanyContact")]
    public string CompanyContact { get; set; }

    [XmlElement("ContactTitle")]
    public string ContactTitle { get; set; }

    [XmlElement("LegalUltimateParentIndicator")]
    public string LegalUltimateParentIndicator { get; set; }

    [XmlElement("LegalImmediateParentIndicator")]
    public string LegalImmediateParentIndicator { get; set; }

    [XmlElement("LegalUltimateParent")]
    public string LegalUltimateParent { get; set; }

    [XmlElement("LegalImmediateParent")]
    public string LegalImmediateParent { get; set; }

    [XmlElement("naicsdetail")]
    public List<NAICSDetail> naicsdetail { get; set; }

    [XmlElement("sicdetail")]
    public List<SICDetail> sicdetail { get; set; }
}
