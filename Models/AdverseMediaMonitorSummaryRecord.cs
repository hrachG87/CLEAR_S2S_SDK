using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaMonitorSummaryRecord")]
public class AdverseMediaMonitorSummaryRecord
{
    [XmlElement("AntitrustViolations")]
    public int AntitrustViolations { get; set; }

    [XmlElement("ArmsTrafficking")]
    public int ArmsTrafficking { get; set; }

    [XmlElement("BriberyCorruption")]
    public int BriberyCorruption { get; set; }

    [XmlElement("CivilLawsuit")]
    public int CivilLawsuit { get; set; }

    [XmlElement("CurrencyCounterfeiting")]
    public int CurrencyCounterfeiting { get; set; }

    [XmlElement("CybercrimeHackingPhishing")]
    public int CybercrimeHackingPhishing { get; set; }

    [XmlElement("DrugNarcoticsTrafficking")]
    public int DrugNarcoticsTrafficking { get; set; }

    [XmlElement("Embezzlement")]
    public int Embezzlement { get; set; }

    [XmlElement("EnvironmentalCrimes")]
    public int EnvironmentalCrimes { get; set; }

    [XmlElement("Extortion")]
    public int Extortion { get; set; }

    [XmlElement("FalsifyingInfo")]
    public int FalsifyingInfo { get; set; }

    [XmlElement("Forgery")]
    public int Forgery { get; set; }

    [XmlElement("Fraud")]
    public int Fraud { get; set; }

    [XmlElement("HostageKidnapping")]
    public int HostageKidnapping { get; set; }

    [XmlElement("HumanTrafficking")]
    public int HumanTrafficking { get; set; }

    [XmlElement("IllicitTrafficking")]
    public int IllicitTrafficking { get; set; }

    [XmlElement("MoneyLaundering")]
    public int MoneyLaundering { get; set; }

    [XmlElement("Racketeering")]
    public int Racketeering { get; set; }

    [XmlElement("PharmaTrafficking")]
    public int PharmaTrafficking { get; set; }

    [XmlElement("PiracyCounterfeiting")]
    public int PiracyCounterfeiting { get; set; }

    [XmlElement("RobberyTheft")]
    public int RobberyTheft { get; set; }

    [XmlElement("SanctionViolations")]
    public int SanctionViolations { get; set; }

    [XmlElement("SecuritiesFraudInsiderTrade")]
    public int SecuritiesFraudInsiderTrade { get; set; }

    [XmlElement("TaxEvasionFraud")]
    public int TaxEvasionFraud { get; set; }

    [XmlElement("TerrorismFinancing")]
    public int TerrorismFinancing { get; set; }

    [XmlElement("WarCrimes")]
    public int WarCrimes { get; set; }

    [XmlElement("MultipleTags")]
    public int MultipleTags { get; set; }

    [XmlElement("Untagged")]
    public int Untagged { get; set; }

}