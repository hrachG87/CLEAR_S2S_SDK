using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DisturbingThePeace")]
public class DisturbingThePeace
{
    [XmlElement("DisturbPeace")]
    public RiskFlagInfo DisturbPeace { get; set; }

}
}