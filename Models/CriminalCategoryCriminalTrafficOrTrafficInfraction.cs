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
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}