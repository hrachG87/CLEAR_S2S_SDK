using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Trespassing")]
public class Trespassing
{
    [XmlElement("TrespassHuntFishPrivate")]
    public RiskFlagInfo TrespassHuntFishPrivate { get; set; }

}
}