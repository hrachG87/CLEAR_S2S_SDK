using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportDetails")]
public class PersonReportDetails
{
    [XmlElement("Status")]
    public ClearReportApiStatus Status { get; set; }

    [XmlElement("ReportId")]
    public string ReportId { get; set; }

    [XmlElement("SectionResults")]
    public List<PersonReportSectionResults> SectionResults { get; set; }

}