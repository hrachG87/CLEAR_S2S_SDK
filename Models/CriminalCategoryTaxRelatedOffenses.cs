using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategoryTaxRelatedOffenses")]
public class CriminalCategoryTaxRelatedOffenses
{
    [XmlElement("IncomeTax")]
    public CriminalChargetypes IncomeTax { get; set; }

    [XmlElement("SalesTax")]
    public CriminalChargetypes SalesTax { get; set; }

    [XmlElement("LiquorTax")]
    public CriminalChargetypes LiquorTax { get; set; }

    [XmlElement("TaxRevenue")]
    public CriminalChargetypes TaxRevenue { get; set; }

    [XmlElement("FalseTaxReturn")]
    public CriminalChargetypes FalseTaxReturn { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}