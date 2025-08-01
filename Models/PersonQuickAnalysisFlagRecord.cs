using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonQuickAnalysisFlagRecord")]
public class PersonQuickAnalysisFlagRecord
{
    [XmlElement("RiskFlags")]
    public PersonReportRiskFlags RiskFlags { get; set; }

    [XmlElement("RiskFlagsWithDocguids")]
    public PersonReportRiskFlagsWithDocguids RiskFlagsWithDocguids { get; set; }

}
}