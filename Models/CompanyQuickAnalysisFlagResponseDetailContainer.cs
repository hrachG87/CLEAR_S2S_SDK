using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyQuickAnalysisFlagResponseDetailContainer")]
public class CompanyQuickAnalysisFlagResponseDetailContainer
{
    [XmlElement("CompanyQuickAnalysisFlagResponseDetail")]
    public CompanyQuickAnalysisFlagResponseDetail CompanyQuickAnalysisFlagResponseDetail { get; set; }
}
