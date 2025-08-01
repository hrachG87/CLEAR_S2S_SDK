using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessRiskFlagInfo")]
public class BusinessRiskFlagInfo
{
    [XmlElement("RiskFlagName")]
    public string RiskFlagName { get; set; }

    [XmlElement("RiskFlagScore")]
    public string RiskFlagScore { get; set; }

    [XmlElement("RiskFlagHitIndicator")]
    public string RiskFlagHitIndicator { get; set; }

    [XmlElement("RiskFlagDetails")]
    public List<RiskFlagDetails> RiskFlagDetails { get; set; }

    [XmlElement("DocumentIdentifierInfo")]
    public List<RiskFlagsDocumentIdentifierInfo> DocumentIdentifierInfo { get; set; }
}
