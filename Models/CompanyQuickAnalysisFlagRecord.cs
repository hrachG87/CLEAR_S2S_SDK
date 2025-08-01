using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyQuickAnalysisFlagRecord")]
public class CompanyQuickAnalysisFlagRecord
{
    [XmlElement("CompanyRiskFlags")]
    public CompanyReportRiskFlags CompanyRiskFlags { get; set; }

    [XmlElement("CompanyRiskFlagsWithDocguids")]
    public CompanyReportRiskFlagsWithDocguids CompanyRiskFlagsWithDocguids { get; set; }

}