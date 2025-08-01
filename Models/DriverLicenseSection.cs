using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DriverLicenseSection")]
public class DriverLicenseSection
{
    [XmlElement("driversLicense")]
    public List<DriversLicense> driversLicense { get; set; }

    [XmlElement("driverLicenseRecord")]
    public List<DriverLicenseRecord> driverLicenseRecord { get; set; }
}
