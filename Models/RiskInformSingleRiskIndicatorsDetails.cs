using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformSingleRiskIndicatorsDetails")]
public class RiskInformSingleRiskIndicatorsDetails
{
    [XmlElement("SingleRiskIndicatorsRecord")]
    public SingleRiskIndicatorsRecord SingleRiskIndicatorsRecord { get; set; }
}
