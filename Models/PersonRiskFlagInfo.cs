using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonRiskFlagInfo")]
public class PersonRiskFlagInfo
{
    [XmlElement("RiskFlag")]
    public string RiskFlag { get; set; }

    [XmlElement("DocumentGuids")]
    public List<FlagsSearchSources> DocumentGuids { get; set; }

    [XmlElement("AssociatesDocumentGuids")]
    public List<FlagsSearchSources> AssociatesDocumentGuids { get; set; }

    [XmlElement("RelativesDocumentGuids")]
    public List<FlagsSearchSources> RelativesDocumentGuids { get; set; }

}