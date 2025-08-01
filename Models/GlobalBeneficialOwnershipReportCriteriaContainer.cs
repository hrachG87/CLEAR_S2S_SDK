using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GlobalBeneficialOwnershipReportCriteriaContainer")]
public class GlobalBeneficialOwnershipReportCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public GlobalBeneficialOwnershipReportCriteria ReportCriteria { get; set; }
}
