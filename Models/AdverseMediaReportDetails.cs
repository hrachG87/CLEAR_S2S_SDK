using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaReportDetails")]
public class AdverseMediaReportDetails
{
    [XmlElement("Status")]
    public ClearReportApiStatus Status { get; set; }

    [XmlElement("SectionResults")]
    public List<AdverseMediaReportSectionResults> SectionResults { get; set; }
}
