using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIPersonReportSingleRiskIndicatorsDetails")]
public class RIPersonReportSingleRiskIndicatorsDetails
{
    [XmlElement("singleRiskIndicatorsRecord")]
    public RIPersonReportSingleRiskIndicatorsRecord singleRiskIndicatorsRecord { get; set; }

}