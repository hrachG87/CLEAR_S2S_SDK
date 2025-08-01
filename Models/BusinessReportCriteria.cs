using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessReportCriteria")]
public class BusinessReportCriteria
{
    [XmlElement("GroupID")]
    public string GroupID { get; set; }

    [XmlElement("ReportChoice")]
    public string ReportChoice { get; set; }

    [XmlElement("ReportSections")]
    public BusinessReportSections ReportSections { get; set; }

    [XmlElement("IncludeArticles")]
    public BusinessReportIncludeArticles IncludeArticles { get; set; }

    [XmlElement("GlobalBeneficialOwnershipCriteria")]
    public GlobalBeneficialOwnershipReportCriteria GlobalBeneficialOwnershipCriteria { get; set; }

}
}