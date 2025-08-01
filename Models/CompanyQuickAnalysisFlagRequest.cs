using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyQuickAnalysisFlagRequest")]
public class CompanyQuickAnalysisFlagRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public CompanyQuickAnalysisCriteria Criteria { get; set; }
}
