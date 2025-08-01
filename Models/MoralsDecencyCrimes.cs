using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MoralsDecencyCrimes")]
public class MoralsDecencyCrimes
{
    [XmlElement("MoralsCrimes")]
    public RiskFlagInfo MoralsCrimes { get; set; }

}
}