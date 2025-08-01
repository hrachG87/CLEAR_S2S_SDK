using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessReportCandidateCriteriaContainer")]
public class BusinessReportCandidateCriteriaContainer
{
    [XmlElement("ReportCandidateCriteria")]
    public BusinessReportCandidateCriteria ReportCandidateCriteria { get; set; }

}