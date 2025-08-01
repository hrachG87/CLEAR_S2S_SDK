using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformBusinessRiskDetails")]
public class RiskInformBusinessRiskDetails
{
    [XmlElement("BusinessRiskRecord")]
    public BusinessRiskRecord BusinessRiskRecord { get; set; }
}
