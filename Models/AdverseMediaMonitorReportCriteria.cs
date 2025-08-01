using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaMonitorReportCriteria")]
public class AdverseMediaMonitorReportCriteria
{
    [XmlElement("ResultId")]
    public string ResultId { get; set; }

    [XmlElement("IncludeArticles")]
    public AdverseMdiaReportIncludeArticles IncludeArticles { get; set; }

    [XmlElement("SelectAllArticles")]
    public bool SelectAllArticles { get; set; }
}
