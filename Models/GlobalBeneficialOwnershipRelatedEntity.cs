using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GlobalBeneficialOwnershipRelatedEntity")]
public class GlobalBeneficialOwnershipRelatedEntity
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("NameOriginalLanguage")]
    public string NameOriginalLanguage { get; set; }

    [XmlElement("FirstReportDate")]
    public string FirstReportDate { get; set; }

    [XmlElement("LastReportDate")]
    public string LastReportDate { get; set; }

    [XmlElement("RelationshipType")]
    public string RelationshipType { get; set; }

    [XmlElement("Former")]
    public string Former { get; set; }

    [XmlElement("RiskIndicators")]
    public RiskIndicators RiskIndicators { get; set; }

    [XmlElement("NumberOfSharesOwned")]
    public List<NumberOfSharesOwned> NumberOfSharesOwned { get; set; }
}
