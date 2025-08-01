using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Conspiracy")]
public class Conspiracy
{
    [XmlElement("ConspiracyFlag")]
    public RiskFlagInfo ConspiracyFlag { get; set; }

}
}