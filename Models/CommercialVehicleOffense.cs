using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CommercialVehicleOffense")]
public class CommercialVehicleOffense
{
    [XmlElement("CommercialVehicleOffense")]
    public RiskFlagInfo CommercialVehicleOffense { get; set; }
}
