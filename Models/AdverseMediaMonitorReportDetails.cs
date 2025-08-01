using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaMonitorReportDetails")]
public class AdverseMediaMonitorReportDetails
{
    [XmlElement("Status")]
    public ClearReportApiStatus Status { get; set; }

    [XmlElement("SectionResults")]
    public List<AdverseMediaMonitorReportSectionResults> SectionResults { get; set; }

}