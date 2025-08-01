using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ExpBusCreditReportCriteriaContainer")]
public class ExpBusCreditReportCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public ExpBusCreditReportCriteria ReportCriteria { get; set; }
}
