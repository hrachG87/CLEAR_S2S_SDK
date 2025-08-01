using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CommercialVehicleOffense")]
public class CommercialVehicleOffense
{
    [XmlElement("CommercialVehicleOffense")]
    public RiskFlagInfo CommercialVehicleOffense { get; set; }

}
}