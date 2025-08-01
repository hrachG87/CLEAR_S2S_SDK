using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MotorVehicleRegistrationOffense")]
public class MotorVehicleRegistrationOffense
{
    [XmlElement("VehicleRegistrationOffense")]
    public RiskFlagInfo VehicleRegistrationOffense { get; set; }

}
}