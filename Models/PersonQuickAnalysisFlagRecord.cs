using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonQuickAnalysisFlagRecord")]
public class PersonQuickAnalysisFlagRecord
{
    [XmlElement("RiskFlags")]
    public PersonReportRiskFlags RiskFlags { get; set; }

    [XmlElement("RiskFlagsWithDocguids")]
    public PersonReportRiskFlagsWithDocguids RiskFlagsWithDocguids { get; set; }
}
