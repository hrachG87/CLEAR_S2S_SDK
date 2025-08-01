using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformHealthcareRiskDetails")]
public class RiskInformHealthcareRiskDetails
{
    [XmlElement("HealthcareRiskRecord")]
    public BusinessRiskRecord HealthcareRiskRecord { get; set; }
}
