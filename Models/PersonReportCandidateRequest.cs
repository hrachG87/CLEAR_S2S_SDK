using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportCandidateRequest")]
public class PersonReportCandidateRequest
{
    [XmlElement("PermissiblePurpose")]
    public ReportPermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public PersonReportCandidateCriteriaContainer Criteria { get; set; }

}