using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyQuickAnalysisFlagCriteria")]
public class CompanyQuickAnalysisFlagCriteria
{
    [XmlElement("EntityId")]
    public string EntityId { get; set; }

    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("CompanyRiskFlags")]
    public CompanyQuickAnalysisRiskFlags CompanyRiskFlags { get; set; }

}