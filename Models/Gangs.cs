using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Gangs")]
public class Gangs
{
    [XmlElement("GangRelatedCrime")]
    public RiskFlagInfo GangRelatedCrime { get; set; }

    [XmlElement("SolicitGangMembers")]
    public RiskFlagInfo SolicitGangMembers { get; set; }

}
}