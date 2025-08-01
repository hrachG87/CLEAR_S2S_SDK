using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("HumanTrafficking")]
public class HumanTrafficking
{
    [XmlElement("HumanTraffickingFlag")]
    public RiskFlagInfo HumanTraffickingFlag { get; set; }

}
}