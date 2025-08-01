using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RIPersonReportSectionResults")]
public class RIPersonReportSectionResults
{
    [XmlElement("SectionName")]
    public string SectionName { get; set; }

    [XmlElement("SectionStatus")]
    public string SectionStatus { get; set; }

    [XmlElement("SectionRecordCount")]
    public int SectionRecordCount { get; set; }

    [XmlElement("SectionDetails")]
    public RIPersonReportSectionDetails SectionDetails { get; set; }

    [XmlElement("CLEARReportDescription")]
    public string CLEARReportDescription { get; set; }
}
