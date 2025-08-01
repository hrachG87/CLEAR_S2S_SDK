using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MortgageDetailInfo")]
public class MortgageDetailInfo
{
    [XmlElement("MortgageAssumptionAmount")]
    public string MortgageAssumptionAmount { get; set; }

    [XmlElement("MortgageDueDate")]
    public string MortgageDueDate { get; set; }

    [XmlElement("MortgateInterestRate")]
    public string MortgateInterestRate { get; set; }

    [XmlElement("MortgageTerm")]
    public string MortgageTerm { get; set; }

    [XmlElement("MortgageTermCode")]
    public string MortgageTermCode { get; set; }

    [XmlElement("SaleOfDeedDate")]
    public string SaleOfDeedDate { get; set; }
}
