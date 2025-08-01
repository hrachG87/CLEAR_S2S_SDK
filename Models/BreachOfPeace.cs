using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BreachOfPeace")]
public class BreachOfPeace
{
    [XmlElement("Anarchism")]
    public RiskFlagInfo Anarchism { get; set; }

    [XmlElement("IncitingRiot")]
    public RiskFlagInfo IncitingRiot { get; set; }

    [XmlElement("EngagingRiot")]
    public RiskFlagInfo EngagingRiot { get; set; }

    [XmlElement("InterfereWithFirearmDuringRiot")]
    public RiskFlagInfo InterfereWithFirearmDuringRiot { get; set; }

    [XmlElement("InterfereWithOfficerDuringRiot")]
    public RiskFlagInfo InterfereWithOfficerDuringRiot { get; set; }

    [XmlElement("Riot")]
    public RiskFlagInfo Riot { get; set; }

    [XmlElement("UnlawfulAssembly")]
    public RiskFlagInfo UnlawfulAssembly { get; set; }

    [XmlElement("DesecratingFlag")]
    public RiskFlagInfo DesecratingFlag { get; set; }

    [XmlElement("ObsceneTelecall")]
    public RiskFlagInfo ObsceneTelecall { get; set; }

    [XmlElement("PublicPeace")]
    public RiskFlagInfo PublicPeace { get; set; }
}
