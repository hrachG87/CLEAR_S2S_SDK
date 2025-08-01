using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DriverAtSubjectAddressRecord")]
public class DriverAtSubjectAddressRecord
{
    [XmlElement("SubjectAddress")]
    public CommonDataAddress SubjectAddress { get; set; }

    [XmlElement("DriverLicenseRecord")]
    public List<DriverLicenseRecord> DriverLicenseRecord { get; set; }

}