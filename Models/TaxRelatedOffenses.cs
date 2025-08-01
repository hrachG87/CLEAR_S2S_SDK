using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("TaxRelatedOffenses")]
public class TaxRelatedOffenses
{
    [XmlElement("IncomeTax")]
    public RiskFlagInfo IncomeTax { get; set; }

    [XmlElement("SalesTax")]
    public RiskFlagInfo SalesTax { get; set; }

    [XmlElement("LiquorTax")]
    public RiskFlagInfo LiquorTax { get; set; }

    [XmlElement("TaxRevenue")]
    public RiskFlagInfo TaxRevenue { get; set; }

    [XmlElement("FalseTaxReturn")]
    public RiskFlagInfo FalseTaxReturn { get; set; }

}