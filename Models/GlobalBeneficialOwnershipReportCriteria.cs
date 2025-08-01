using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GlobalBeneficialOwnershipReportCriteria")]
public class GlobalBeneficialOwnershipReportCriteria
{
    [XmlElement("GroupID")]
    public string GroupID { get; set; }

    [XmlElement("ReportOptions")]
    public GlobalBeneficialOwnershipReportOptions ReportOptions { get; set; }

    [XmlElement("ReportSections")]
    public GlobalBeneficialOwnershipReportSectionSelector ReportSections { get; set; }

}
}