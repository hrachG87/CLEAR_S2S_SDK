using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SecretService")]
public class SecretService
{
    [XmlElement("ThreatToProtectee")]
    public RiskFlagInfo ThreatToProtectee { get; set; }

    [XmlElement("DeportedFelon")]
    public RiskFlagInfo DeportedFelon { get; set; }

    [XmlElement("AlienUnlawfullyPresent")]
    public RiskFlagInfo AlienUnlawfullyPresent { get; set; }

    [XmlElement("ViolationOfNSR")]
    public RiskFlagInfo ViolationOfNSR { get; set; }

}
}