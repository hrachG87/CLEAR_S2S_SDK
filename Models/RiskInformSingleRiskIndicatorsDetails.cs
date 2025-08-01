using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformSingleRiskIndicatorsDetails")]
public class RiskInformSingleRiskIndicatorsDetails
{
    [XmlElement("SingleRiskIndicatorsRecord")]
    public SingleRiskIndicatorsRecord SingleRiskIndicatorsRecord { get; set; }

}
}