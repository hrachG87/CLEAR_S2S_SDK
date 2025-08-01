using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessReportDetails")]
public class BusinessReportDetails
{
    [XmlElement("Status")]
    public ClearReportApiStatus Status { get; set; }

    [XmlElement("ReportId")]
    public string ReportId { get; set; }

    [XmlElement("SectionResults")]
    public List<CompanyReportSectionResults> SectionResults { get; set; }

}