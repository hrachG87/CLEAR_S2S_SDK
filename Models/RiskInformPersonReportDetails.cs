using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformPersonReportDetails")]
public class RiskInformPersonReportDetails
{
    [XmlElement("Status")]
    public ClearReportApiStatus Status { get; set; }

    [XmlElement("ReportId")]
    public string ReportId { get; set; }

    [XmlElement("SectionResults")]
    public List<RIPersonReportSectionResults> SectionResults { get; set; }

}