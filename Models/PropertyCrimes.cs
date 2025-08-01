using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PropertyCrimes")]
public class PropertyCrimes
{
    [XmlElement("PropertyCrimesRemarks")]
    public RiskFlagInfo PropertyCrimesRemarks { get; set; }

}
}