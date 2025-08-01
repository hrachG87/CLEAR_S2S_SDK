using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskDashboardSection")]
public class RiskDashboardSection
{
    [XmlElement("RiskDashboardRecord")]
    public List<RiskDashboardRecord> RiskDashboardRecord { get; set; }

}