using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformBusinessReportRequest")]
public class RiskInformBusinessReportRequest
{
    [XmlElement("PermissiblePurpose")]
    public ReportPermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public RiskInformBusinessReportCriteriaContainer Criteria { get; set; }

}