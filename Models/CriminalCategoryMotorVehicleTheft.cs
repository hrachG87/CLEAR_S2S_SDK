using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryMotorVehicleTheft")]
public class CriminalCategoryMotorVehicleTheft
{
    [XmlElement("TheftSaleVehicle")]
    public CriminalChargetypes TheftSaleVehicle { get; set; }

    [XmlElement("TheftStripVehicle")]
    public CriminalChargetypes TheftStripVehicle { get; set; }

    [XmlElement("TheftUseVehicleCrime")]
    public CriminalChargetypes TheftUseVehicleCrime { get; set; }

    [XmlElement("TheftVehicle")]
    public CriminalChargetypes TheftVehicle { get; set; }

    [XmlElement("TheftVehicleBailee")]
    public CriminalChargetypes TheftVehicleBailee { get; set; }

    [XmlElement("ReceiptStolenVehicle")]
    public CriminalChargetypes ReceiptStolenVehicle { get; set; }

    [XmlElement("StripStolenVehicle")]
    public CriminalChargetypes StripStolenVehicle { get; set; }

    [XmlElement("PossessStolenVehicle")]
    public CriminalChargetypes PossessStolenVehicle { get; set; }

    [XmlElement("InterstateTransportStolenVehicle")]
    public CriminalChargetypes InterstateTransportStolenVehicle { get; set; }

    [XmlElement("TheftAircraft")]
    public CriminalChargetypes TheftAircraft { get; set; }

    [XmlElement("JoyRiding")]
    public CriminalChargetypes JoyRiding { get; set; }

    [XmlElement("VehicleTheft")]
    public CriminalChargetypes VehicleTheft { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
