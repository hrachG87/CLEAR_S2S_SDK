using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SolicitingCrime")]
public class SolicitingCrime
{
    [XmlElement("SolicitCrime")]
    public RiskFlagInfo SolicitCrime { get; set; }

}
}