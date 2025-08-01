using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessReportCandidateCriteria")]
public class BusinessReportCandidateCriteria
{
    [XmlElement("ReportCandidate")]
    public BusinessReportCandidate ReportCandidate { get; set; }

    [XmlElement("ReportChoice")]
    public string ReportChoice { get; set; }

    [XmlElement("ReportSections")]
    public BusinessReportCandidateSections ReportSections { get; set; }

    [XmlElement("IncludeArticles")]
    public BusinessReportIncludeArticles IncludeArticles { get; set; }

}