using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaMonitorReportSectionResults")]
public class AdverseMediaMonitorReportSectionResults
{
    [XmlElement("SectionName")]
    public string SectionName { get; set; }

    [XmlElement("SectionStatus")]
    public string SectionStatus { get; set; }

    [XmlElement("SectionRecordCount")]
    public int SectionRecordCount { get; set; }

    [XmlElement("SectionDetails")]
    public AdverseMediaMonitorReportSectionDetails SectionDetails { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("CLEARReportDescription")]
    public string CLEARReportDescription { get; set; }

}