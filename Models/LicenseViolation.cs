using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LicenseViolation")]
public class LicenseViolation
{
    [XmlElement("ProfLicViolation")]
    public RiskFlagInfo ProfLicViolation { get; set; }

    [XmlElement("BizLicViolation")]
    public RiskFlagInfo BizLicViolation { get; set; }

}