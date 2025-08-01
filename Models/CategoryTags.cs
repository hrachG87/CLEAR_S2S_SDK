using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CategoryTags")]
public class CategoryTags
{
    [XmlElement("Untagged")]
    public bool Untagged { get; set; }

    [XmlElement("AntitrustViolations")]
    public bool AntitrustViolations { get; set; }

    [XmlElement("ArmsTrafficking")]
    public bool ArmsTrafficking { get; set; }

    [XmlElement("BriberyCorruption")]
    public bool BriberyCorruption { get; set; }

    [XmlElement("CivilLawsuit")]
    public bool CivilLawsuit { get; set; }

    [XmlElement("CurrencyCounterfeiting")]
    public bool CurrencyCounterfeiting { get; set; }

    [XmlElement("CybercrimeHackingPhishing")]
    public bool CybercrimeHackingPhishing { get; set; }

    [XmlElement("DrugNarcoticsTrafficking")]
    public bool DrugNarcoticsTrafficking { get; set; }

    [XmlElement("Embezzlement")]
    public bool Embezzlement { get; set; }

    [XmlElement("EnvironmentalCrimes")]
    public bool EnvironmentalCrimes { get; set; }

    [XmlElement("Extortion")]
    public bool Extortion { get; set; }

    [XmlElement("FalsifyingInfo")]
    public bool FalsifyingInfo { get; set; }

    [XmlElement("Forgery")]
    public bool Forgery { get; set; }

    [XmlElement("Fraud")]
    public bool Fraud { get; set; }

    [XmlElement("HostageKidnapping")]
    public bool HostageKidnapping { get; set; }

    [XmlElement("HumanTrafficking")]
    public bool HumanTrafficking { get; set; }

    [XmlElement("IllicitTrafficking")]
    public bool IllicitTrafficking { get; set; }

    [XmlElement("MoneyLaundering")]
    public bool MoneyLaundering { get; set; }

    [XmlElement("Racketeering")]
    public bool Racketeering { get; set; }

    [XmlElement("PharmaTrafficking")]
    public bool PharmaTrafficking { get; set; }

    [XmlElement("PiracyCounterfeiting")]
    public bool PiracyCounterfeiting { get; set; }

    [XmlElement("RobberyTheft")]
    public bool RobberyTheft { get; set; }

    [XmlElement("SanctionViolations")]
    public bool SanctionViolations { get; set; }

    [XmlElement("SecuritiesFraudInsiderTrade")]
    public bool SecuritiesFraudInsiderTrade { get; set; }

    [XmlElement("TaxEvasionFraud")]
    public bool TaxEvasionFraud { get; set; }

    [XmlElement("TerrorismFinancing")]
    public bool TerrorismFinancing { get; set; }

    [XmlElement("WarCrimes")]
    public bool WarCrimes { get; set; }

    [XmlElement("Sanctions")]
    public bool Sanctions { get; set; }

    [XmlElement("StateOwnedEntities")]
    public bool StateOwnedEntities { get; set; }

    [XmlElement("PoliticallyExposedPersons")]
    public bool PoliticallyExposedPersons { get; set; }
}
