using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportCriteria")]
public class PersonReportCriteria
{
    [XmlElement("GroupID")]
    public string GroupID { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("ReportChoice")]
    public string ReportChoice { get; set; }

    [XmlElement("ReportOptions")]
    public PersonReportOptions ReportOptions { get; set; }

    [XmlElement("ReportSections")]
    public PersonReportSectionContainer ReportSections { get; set; }

    [XmlElement("IncludeArticles")]
    public PersonReportIncludeArticles IncludeArticles { get; set; }

}