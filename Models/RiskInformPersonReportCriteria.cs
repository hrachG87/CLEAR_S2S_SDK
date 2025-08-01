using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPersonReportCriteria")]
public class RiskInformPersonReportCriteria
{
    [XmlElement("GroupID")]
    public string GroupID { get; set; }

    [XmlElement("ReportChoice")]
    public string ReportChoice { get; set; }

    [XmlElement("ReportDisplayHitRiskFlagsOnly")]
    public string ReportDisplayHitRiskFlagsOnly { get; set; }

    [XmlElement("ReportOptions")]
    public RiskInformPersonReportOptions ReportOptions { get; set; }

    [XmlElement("ReportSections")]
    public RiskInformPersonReportSectionSelectors ReportSections { get; set; }

    [XmlElement("IncludeArticles")]
    public RiskInformPersonReportIncludeArticles IncludeArticles { get; set; }

}
}