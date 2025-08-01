using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportCandidateCriteriaContainer")]
public class PersonReportCandidateCriteriaContainer
{
    [XmlElement("ReportCandidateCriteria")]
    public PersonReportCandidateCriteria ReportCandidateCriteria { get; set; }

}