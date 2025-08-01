using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyQuickAnalysisFlagSection")]
public class CompanyQuickAnalysisFlagSection
{
    [XmlElement("QuickAnalysisFlagRecord")]
    public List<CompanyQuickAnalysisFlagRecord> QuickAnalysisFlagRecord { get; set; }
}
