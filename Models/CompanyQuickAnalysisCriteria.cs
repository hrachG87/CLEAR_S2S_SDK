using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyQuickAnalysisCriteria")]
public class CompanyQuickAnalysisCriteria
{
    [XmlElement("CompanyQuickAnalysisFlagCriteria")]
    public CompanyQuickAnalysisFlagCriteria CompanyQuickAnalysisFlagCriteria { get; set; }

}
}