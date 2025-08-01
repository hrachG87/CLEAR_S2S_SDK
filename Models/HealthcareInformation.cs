using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("HealthcareInformation")]
public class HealthcareInformation
{
    [XmlElement("HealthcareSanctionSingle")]
    public RiskFlagInfo HealthcareSanctionSingle { get; set; }

    [XmlElement("HealthcareSanctionMultiple")]
    public RiskFlagInfo HealthcareSanctionMultiple { get; set; }

    [XmlElement("HealthcareLicense")]
    public RiskFlagInfo HealthcareLicense { get; set; }

    [XmlElement("NPI")]
    public RiskFlagInfo NPI { get; set; }
}
