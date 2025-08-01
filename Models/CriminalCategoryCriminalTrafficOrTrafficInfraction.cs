using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryCriminalTrafficOrTrafficInfraction")]
public class CriminalCategoryCriminalTrafficOrTrafficInfraction
{
    [XmlElement("TrafficOffense")]
    public CriminalSubcategoryTrafficOffense TrafficOffense { get; set; }

    [XmlElement("DrivingWhileIntoxicated")]
    public CriminalSubcategoryDrivingWhileIntoxicated DrivingWhileIntoxicated { get; set; }

    [XmlElement("DriversLicenseOffense")]
    public CriminalSubcategoryDriversLicenseOffense DriversLicenseOffense { get; set; }

    [XmlElement("MotorVehicleEquipmentViolation")]
    public CriminalSubcategoryMotorVehicleEquipmentViolation MotorVehicleEquipmentViolation { get; set; }

    [XmlElement("MotorVehicleRegistrationOffense")]
    public CriminalSubcategoryMotorVehicleRegistrationOffense MotorVehicleRegistrationOffense { get; set; }

    [XmlElement("CommercialVehicleOffense")]
    public CriminalSubcategoryCommercialVehicleOffense CommercialVehicleOffense { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
