using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyQuickAnalysisFlagResponseDetail")]
public class CompanyQuickAnalysisFlagResponseDetail
{
    [XmlElement("companyRiskFlagsWithDocguids")]
    public CompanyRiskFlagsWithDocguids companyRiskFlagsWithDocguids { get; set; }

}
}