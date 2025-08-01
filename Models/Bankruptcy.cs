using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Bankruptcy")]
public class Bankruptcy
{
    [XmlElement("BankruptcyPersonal")]
    public RiskFlagInfo BankruptcyPersonal { get; set; }

    [XmlElement("BankruptcyDischargedPersonal")]
    public RiskFlagInfo BankruptcyDischargedPersonal { get; set; }

    [XmlElement("BankruptcyBusiness")]
    public RiskFlagInfo BankruptcyBusiness { get; set; }

    [XmlElement("BankruptcyDischargedBusiness")]
    public RiskFlagInfo BankruptcyDischargedBusiness { get; set; }

    [XmlElement("MultipleBankruptciesPersonal")]
    public RiskFlagInfo MultipleBankruptciesPersonal { get; set; }

    [XmlElement("MultipleBankruptciesBusiness")]
    public RiskFlagInfo MultipleBankruptciesBusiness { get; set; }

    [XmlElement("MultipleBankruptciesPersonalAndBusiness")]
    public RiskFlagInfo MultipleBankruptciesPersonalAndBusiness { get; set; }
}
