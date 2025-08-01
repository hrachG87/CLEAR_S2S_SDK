using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaReportCriteria")]
public class AdverseMediaReportCriteria
{
    [XmlElement("SearchId")]
    public string SearchId { get; set; }

    [XmlElement("ArticleOrder")]
    public string ArticleOrder { get; set; }

    [XmlElement("SelectAllArticles")]
    public bool SelectAllArticles { get; set; }

    [XmlElement("ReportSections")]
    public AdverseMediaReportSections ReportSections { get; set; }

    [XmlElement("IncludeArticles")]
    public AdverseMdiaReportIncludeArticles IncludeArticles { get; set; }

}