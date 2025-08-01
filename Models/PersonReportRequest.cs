using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportRequest")]
public class PersonReportRequest
{
    [XmlElement("PermissiblePurpose")]
    public ReportPermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public PersonReportCriteriaContainer Criteria { get; set; }

}