using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GlobalBeneficialOwnershipResponseDetail")]
public class GlobalBeneficialOwnershipResponseDetail
{
    [XmlElement("PersonName")]
    public string PersonName { get; set; }

    [XmlElement("PersonNameOriginalLanguage")]
    public string PersonNameOriginalLanguage { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("BusinessNameOriginalLanguage")]
    public string BusinessNameOriginalLanguage { get; set; }

    [XmlElement("BusinessPurposes")]
    public List<GlobalBeneficialOwnershipBusinessPurpose> BusinessPurposes { get; set; }

    [XmlElement("FEIN")]
    public string FEIN { get; set; }

    [XmlElement("Identifier")]
    public List<GlobalBeneficialOwnershipIdentifier> Identifier { get; set; }

    [XmlElement("Sanctioned")]
    public bool Sanctioned { get; set; }

    [XmlElement("PEP")]
    public bool PEP { get; set; }

    [XmlElement("RiskIndicators")]
    public RiskIndicators RiskIndicators { get; set; }

    [XmlElement("Address")]
    public List<GlobalBeneficialOwnershipAddress> Address { get; set; }

    [XmlElement("ReferenceCount")]
    public string ReferenceCount { get; set; }

    [XmlElement("Country")]
    public List<string> Country { get; set; }

    [XmlElement("SourceName")]
    public List<string> SourceName { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("DUNSNumber")]
    public string DUNSNumber { get; set; }
}
