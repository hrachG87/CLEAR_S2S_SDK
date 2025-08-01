using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PublicOrderCrimes")]
public class PublicOrderCrimes
{
    [XmlElement("PublicOrderCrimesFlag")]
    public RiskFlagInfo PublicOrderCrimesFlag { get; set; }

}
}