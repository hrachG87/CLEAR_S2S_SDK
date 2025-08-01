using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MotorVehicleTheft")]
public class MotorVehicleTheft
{
    [XmlElement("TheftSaleVehicle")]
    public RiskFlagInfo TheftSaleVehicle { get; set; }

    [XmlElement("TheftStripVehicle")]
    public RiskFlagInfo TheftStripVehicle { get; set; }

    [XmlElement("TheftUseVehicleCrime")]
    public RiskFlagInfo TheftUseVehicleCrime { get; set; }

    [XmlElement("TheftVehicle")]
    public RiskFlagInfo TheftVehicle { get; set; }

    [XmlElement("TheftVehicleBailee")]
    public RiskFlagInfo TheftVehicleBailee { get; set; }

    [XmlElement("ReceiptStolenVehicle")]
    public RiskFlagInfo ReceiptStolenVehicle { get; set; }

    [XmlElement("StripStolenVehicle")]
    public RiskFlagInfo StripStolenVehicle { get; set; }

    [XmlElement("PossessionStolenVehicle")]
    public RiskFlagInfo PossessionStolenVehicle { get; set; }

    [XmlElement("InterstateTransportStolenVehicle")]
    public RiskFlagInfo InterstateTransportStolenVehicle { get; set; }

    [XmlElement("TheftAircraft")]
    public RiskFlagInfo TheftAircraft { get; set; }

    [XmlElement("JoyRiding")]
    public RiskFlagInfo JoyRiding { get; set; }

    [XmlElement("VehicleTheft")]
    public RiskFlagInfo VehicleTheft { get; set; }
}
