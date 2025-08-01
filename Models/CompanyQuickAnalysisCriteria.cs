using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyQuickAnalysisCriteria")]
public class CompanyQuickAnalysisCriteria
{
    [XmlElement("CompanyQuickAnalysisFlagCriteria")]
    public CompanyQuickAnalysisFlagCriteria CompanyQuickAnalysisFlagCriteria { get; set; }

}