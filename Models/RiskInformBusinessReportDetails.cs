using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformBusinessReportDetails")]
public class RiskInformBusinessReportDetails
{
    [XmlElement("Status")]
    public ClearReportApiStatus Status { get; set; }

    [XmlElement("ReportId")]
    public string ReportId { get; set; }

    [XmlElement("SectionResults")]
    public List<RiskInformBusinessReportSectionResults> SectionResults { get; set; }

}