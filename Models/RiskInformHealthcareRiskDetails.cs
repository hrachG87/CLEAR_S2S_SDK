using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformHealthcareRiskDetails")]
public class RiskInformHealthcareRiskDetails
{
    [XmlElement("HealthcareRiskRecord")]
    public BusinessRiskRecord HealthcareRiskRecord { get; set; }

}
}