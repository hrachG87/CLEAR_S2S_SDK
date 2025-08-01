using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessReportCandidateRequest")]
public class BusinessReportCandidateRequest
{
    [XmlElement("PermissiblePurpose")]
    public ReportPermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public BusinessReportCandidateCriteriaContainer Criteria { get; set; }

}