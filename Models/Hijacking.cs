using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Hijacking")]
public class Hijacking
{
    [XmlElement("HijackPublicTransportation")]
    public RiskFlagInfo HijackPublicTransportation { get; set; }

    [XmlElement("AircraftHijack")]
    public RiskFlagInfo AircraftHijack { get; set; }

}
}