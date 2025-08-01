using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonQuickAnalysisFlagResponseDetail")]
public class PersonQuickAnalysisFlagResponseDetail
{
    [XmlElement("PersonRiskFlags")]
    public RiskFlags PersonRiskFlags { get; set; }

    [XmlElement("PersonRiskFlagsWithDocguids")]
    public PersonRiskFlagsWithDocguids PersonRiskFlagsWithDocguids { get; set; }

}
}