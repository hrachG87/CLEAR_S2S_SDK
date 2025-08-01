using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategoryMoneyLaundering")]
public class CriminalCategoryMoneyLaundering
{
    [XmlElement("MoneyLaunderingTaxBased")]
    public CriminalChargetypes MoneyLaunderingTaxBased { get; set; }

    [XmlElement("MoneyLaunderingRemarks")]
    public CriminalChargetypes MoneyLaunderingRemarks { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}