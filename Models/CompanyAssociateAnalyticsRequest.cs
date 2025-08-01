using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyAssociateAnalyticsRequest")]
public class CompanyAssociateAnalyticsRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public CompanyAssociateAnalyticsUserCriteria Criteria { get; set; }
}
