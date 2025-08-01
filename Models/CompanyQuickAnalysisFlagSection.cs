using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyQuickAnalysisFlagSection")]
public class CompanyQuickAnalysisFlagSection
{
    [XmlElement("QuickAnalysisFlagRecord")]
    public List<CompanyQuickAnalysisFlagRecord> QuickAnalysisFlagRecord { get; set; }

}
}