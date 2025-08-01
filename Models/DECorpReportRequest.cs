using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DECorpReportRequest")]
public class DECorpReportRequest
{
    [XmlElement("PermissiblePurpose")]
    public ReportPermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public DECorpReportCriteriaContainer Criteria { get; set; }

}