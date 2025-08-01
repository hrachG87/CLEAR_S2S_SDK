using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyRiskFlagInfo")]
public class CompanyRiskFlagInfo
{
    [XmlElement("RiskFlag")]
    public string RiskFlag { get; set; }

    [XmlElement("DocumentGuids")]
    public List<FlagsSearchSources> DocumentGuids { get; set; }

    [XmlElement("FlagInfo")]
    public List<FlagSearchFlagInfo> FlagInfo { get; set; }

}
}