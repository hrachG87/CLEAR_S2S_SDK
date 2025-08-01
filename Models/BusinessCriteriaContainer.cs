using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessCriteriaContainer")]
public class BusinessCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public BusinessReportCriteria ReportCriteria { get; set; }
}
