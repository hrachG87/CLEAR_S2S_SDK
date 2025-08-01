using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GlobalBeneficialOwnershipReportCriteriaContainer")]
public class GlobalBeneficialOwnershipReportCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public GlobalBeneficialOwnershipReportCriteria ReportCriteria { get; set; }

}
}