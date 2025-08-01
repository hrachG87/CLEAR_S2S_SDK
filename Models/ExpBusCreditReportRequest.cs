using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ExpBusCreditReportRequest")]
public class ExpBusCreditReportRequest
{
    [XmlElement("PermissiblePurpose")]
    public ReportPermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public ExpBusCreditReportCriteriaContainer Criteria { get; set; }
}
