using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DECorpReportCriteriaContainer")]
public class DECorpReportCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public DECorpReportCriteria ReportCriteria { get; set; }

}