using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalSubcategoryDriversLicenseOffense")]
public class CriminalSubcategoryDriversLicenseOffense
{
    [XmlElement("DrivingUnderSuspension")]
    public CriminalChargetypes DrivingUnderSuspension { get; set; }

    [XmlElement("DrivingAfterRevocation")]
    public CriminalChargetypes DrivingAfterRevocation { get; set; }

    [XmlElement("LicenseOffenses")]
    public CriminalChargetypes LicenseOffenses { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
