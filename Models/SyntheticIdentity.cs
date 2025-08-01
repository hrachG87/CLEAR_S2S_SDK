using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SyntheticIdentity")]
public class SyntheticIdentity
{
    [XmlElement("ThinnessOfFile")]
    public RiskFlagInfo ThinnessOfFile { get; set; }

    [XmlElement("NoRelatives")]
    public RiskFlagInfo NoRelatives { get; set; }

    [XmlElement("NoAssociates")]
    public RiskFlagInfo NoAssociates { get; set; }

    [XmlElement("AgeIssues")]
    public RiskFlagInfo AgeIssues { get; set; }

    [XmlElement("DuplicatePersonalInfo")]
    public RiskFlagInfoWithPersonInfo DuplicatePersonalInfo { get; set; }

    [XmlElement("NewPublicRecordsFootprint")]
    public RiskFlagInfo NewPublicRecordsFootprint { get; set; }

    [XmlElement("AdverseRecords")]
    public RiskFlagInfo AdverseRecords { get; set; }

    [XmlElement("PublicRecordActivityAfterDeath")]
    public RiskFlagInfo PublicRecordActivityAfterDeath { get; set; }

    [XmlElement("SSNMatchesMultipleIndividuals")]
    public RiskFlagInfo SSNMatchesMultipleIndividuals { get; set; }
}
