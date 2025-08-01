using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformBusinessReportCriteriaContainer")]
public class RiskInformBusinessReportCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public RiskInformBusinessReportCriteria ReportCriteria { get; set; }

}