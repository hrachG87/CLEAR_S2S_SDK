using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformBusinessReportCriteria")]
public class RiskInformBusinessReportCriteria
{
    [XmlElement("GroupID")]
    public string GroupID { get; set; }

    [XmlElement("ReportChoice")]
    public string ReportChoice { get; set; }

    [XmlElement("ReportDisplayHitRiskFlagsOnly")]
    public string ReportDisplayHitRiskFlagsOnly { get; set; }

    [XmlElement("ReportSections")]
    public RiskInformBusinessReportSectionSelectors ReportSections { get; set; }

    [XmlElement("IncludeArticles")]
    public RiskInformBusinessReportIncludeArticles IncludeArticles { get; set; }

}
}