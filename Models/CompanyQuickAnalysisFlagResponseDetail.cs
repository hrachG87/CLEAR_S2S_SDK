using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyQuickAnalysisFlagResponseDetail")]
public class CompanyQuickAnalysisFlagResponseDetail
{
    [XmlElement("companyRiskFlagsWithDocguids")]
    public CompanyRiskFlagsWithDocguids companyRiskFlagsWithDocguids { get; set; }

}