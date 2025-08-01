using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SeriousCriminalTrafficOffenses")]
public class SeriousCriminalTrafficOffenses
{
    [XmlElement("HitAndRun")]
    public RiskFlagInfo HitAndRun { get; set; }
}
