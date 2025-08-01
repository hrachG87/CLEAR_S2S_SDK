using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformPersonReportCriteriaContainer")]
public class RiskInformPersonReportCriteriaContainer
{
    [XmlElement("reportCriteria")]
    public RiskInformPersonReportCriteria reportCriteria { get; set; }

}