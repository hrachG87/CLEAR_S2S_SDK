using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonReportSingleRiskIndicatorsDetails")]
public class RIPersonReportSingleRiskIndicatorsDetails
{
    [XmlElement("singleRiskIndicatorsRecord")]
    public RIPersonReportSingleRiskIndicatorsRecord singleRiskIndicatorsRecord { get; set; }

}
}