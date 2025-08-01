using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CrimesAgainstPerson")]
public class CrimesAgainstPerson
{
    [XmlElement("CrimesAgainstPersonFlag")]
    public RiskFlagInfo CrimesAgainstPersonFlag { get; set; }

}
}