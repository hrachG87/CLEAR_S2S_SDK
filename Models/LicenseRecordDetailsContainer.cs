using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("LicenseRecordDetailsContainer")]
public class LicenseRecordDetailsContainer
{
    [XmlElement("licenseResponseDetail")]
    public LicenseResponseDetail licenseResponseDetail { get; set; }
}
