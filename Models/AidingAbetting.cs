using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AidingAbetting")]
public class AidingAbetting
{
    [XmlElement("AidAbetOffense")]
    public RiskFlagInfo AidAbetOffense { get; set; }

}
}