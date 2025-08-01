using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonQuickAnalysisFlagCriteria")]
public class PersonQuickAnalysisFlagCriteria
{
    [XmlElement("EntityId")]
    public string EntityId { get; set; }

    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RelativesIncludeAkasOption")]
    public bool RelativesIncludeAkasOption { get; set; }

    [XmlElement("personRiskFlags")]
    public PersonQuickAnalysisRiskFlags personRiskFlags { get; set; }

    [XmlElement("PersonRiskFlagsSearchOptions")]
    public PersonRiskFlagsSearchOptions PersonRiskFlagsSearchOptions { get; set; }

    [XmlElement("RelativesMinimumStrengthOfAssociation")]
    public int RelativesMinimumStrengthOfAssociation { get; set; }
}
