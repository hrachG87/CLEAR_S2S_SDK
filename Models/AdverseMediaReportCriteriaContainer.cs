using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaReportCriteriaContainer")]
public class AdverseMediaReportCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public AdverseMediaReportCriteria ReportCriteria { get; set; }

}