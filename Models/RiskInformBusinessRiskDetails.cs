using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformBusinessRiskDetails")]
public class RiskInformBusinessRiskDetails
{
    [XmlElement("BusinessRiskRecord")]
    public BusinessRiskRecord BusinessRiskRecord { get; set; }

}
}