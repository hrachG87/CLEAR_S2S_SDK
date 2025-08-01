using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportCandidateCriteria")]
public class PersonReportCandidateCriteria
{
    [XmlElement("ReportCandidate")]
    public ReportCandidate ReportCandidate { get; set; }

    [XmlElement("ReportChoice")]
    public string ReportChoice { get; set; }

    [XmlElement("ReportOptions")]
    public PersonReportOptions ReportOptions { get; set; }

    [XmlElement("ReportSections")]
    public PersonReportSectionContainer ReportSections { get; set; }

    [XmlElement("IncludeArticles")]
    public PersonReportIncludeArticles IncludeArticles { get; set; }

}