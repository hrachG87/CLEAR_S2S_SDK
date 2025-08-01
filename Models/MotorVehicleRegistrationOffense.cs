using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("MotorVehicleRegistrationOffense")]
public class MotorVehicleRegistrationOffense
{
    [XmlElement("VehicleRegistrationOffense")]
    public RiskFlagInfo VehicleRegistrationOffense { get; set; }

}