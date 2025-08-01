using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonReportRiskFlagInfo")]
public class PersonReportRiskFlagInfo
{
    [XmlElement("RiskFlag")]
    public string RiskFlag { get; set; }

    [XmlElement("DocumentGuids")]
    public List<PersonSources> DocumentGuids { get; set; }
}
