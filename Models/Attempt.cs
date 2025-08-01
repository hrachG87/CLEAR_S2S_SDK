using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Attempt")]
public class Attempt
{
    [XmlElement("AttemptMurderOfLawEnforcement")]
    public RiskFlagInfo AttemptMurderOfLawEnforcement { get; set; }

    [XmlElement("HomicideAttemptMurder")]
    public RiskFlagInfo HomicideAttemptMurder { get; set; }

    [XmlElement("AttemptFlag")]
    public RiskFlagInfo AttemptFlag { get; set; }
}
