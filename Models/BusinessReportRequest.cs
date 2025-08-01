using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessReportRequest")]
public class BusinessReportRequest
{
    [XmlElement("PermissiblePurpose")]
    public ReportPermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public BusinessCriteriaContainer Criteria { get; set; }

}