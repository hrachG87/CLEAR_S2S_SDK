using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportRiskFlagInfo")]
public class CompanyReportRiskFlagInfo
{
    [XmlElement("RiskFlag")]
    public string RiskFlag { get; set; }

    [XmlElement("DocumentGuids")]
    public List<CompanySources> DocumentGuids { get; set; }

    [XmlElement("FlagInfo")]
    public List<CompanyReportFlagInfo> FlagInfo { get; set; }

}
}