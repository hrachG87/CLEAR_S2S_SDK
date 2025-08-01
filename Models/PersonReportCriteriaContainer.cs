using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonReportCriteriaContainer")]
public class PersonReportCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public PersonReportCriteria ReportCriteria { get; set; }
}
