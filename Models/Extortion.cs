using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Extortion")]
public class Extortion
{
    [XmlElement("ExtortionThreatInjurePerson")]
    public RiskFlagInfo ExtortionThreatInjurePerson { get; set; }

    [XmlElement("ExtortionThreatDamageProperty")]
    public RiskFlagInfo ExtortionThreatDamageProperty { get; set; }

    [XmlElement("ExtortionThreatInjureReputation")]
    public RiskFlagInfo ExtortionThreatInjureReputation { get; set; }

    [XmlElement("ExtortionThreatAccusingOfCrime")]
    public RiskFlagInfo ExtortionThreatAccusingOfCrime { get; set; }

    [XmlElement("ExtortionThreatInformOfViolence")]
    public RiskFlagInfo ExtortionThreatInformOfViolence { get; set; }

    [XmlElement("ExtortionFlag")]
    public RiskFlagInfo ExtortionFlag { get; set; }
}
