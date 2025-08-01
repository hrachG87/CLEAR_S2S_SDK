using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AccessoryToOffense")]
public class AccessoryToOffense
{
    [XmlElement("AccessoryToOffenseFlag")]
    public RiskFlagInfo AccessoryToOffenseFlag { get; set; }

}
}