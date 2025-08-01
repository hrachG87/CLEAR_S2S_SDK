using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AnnualFinancialsRecord")]
public class AnnualFinancialsRecord
{
    [XmlElement("IncomeStatement")]
    public TableLayout IncomeStatement { get; set; }

    [XmlElement("BalanceSheet")]
    public TableLayout BalanceSheet { get; set; }

    [XmlElement("StatementOfCashFlows")]
    public TableLayout StatementOfCashFlows { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

}
}