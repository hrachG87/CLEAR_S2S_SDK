using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalTrafficOrTrafficInfraction")]
public class CriminalTrafficOrTrafficInfraction
{
    [XmlElement("TransportDangerousMaterial")]
    public RiskFlagInfo TransportDangerousMaterial { get; set; }

    [XmlElement("DrivingUnderInfluenceOfDrugs")]
    public RiskFlagInfo DrivingUnderInfluenceOfDrugs { get; set; }

    [XmlElement("DrivingUnderInfluenceOfLiquor")]
    public RiskFlagInfo DrivingUnderInfluenceOfLiquor { get; set; }

    [XmlElement("RefuseBloodAlcoholTest")]
    public RiskFlagInfo RefuseBloodAlcoholTest { get; set; }

    [XmlElement("DrivingUnderSuspension")]
    public RiskFlagInfo DrivingUnderSuspension { get; set; }

    [XmlElement("DrivingAfterRevocation")]
    public RiskFlagInfo DrivingAfterRevocation { get; set; }

    [XmlElement("LicenseOffenses")]
    public RiskFlagInfo LicenseOffenses { get; set; }

    [XmlElement("MotorVehicleEquipmentViolation")]
    public RiskFlagInfo MotorVehicleEquipmentViolation { get; set; }

    [XmlElement("IgnitionTampering")]
    public RiskFlagInfo IgnitionTampering { get; set; }

}