using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("HealthcareLicenseSection")]
public class HealthcareLicenseSection
{
    [XmlElement("HealthcareLicenseRecord")]
    public List<HealthcareLicenseRecord> HealthcareLicenseRecord { get; set; }
}
