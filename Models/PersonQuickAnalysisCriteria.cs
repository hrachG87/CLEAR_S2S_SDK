using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonQuickAnalysisCriteria")]
public class PersonQuickAnalysisCriteria
{
    [XmlElement("PersonQuickAnalysisFlagCriteria")]
    public PersonQuickAnalysisFlagCriteria PersonQuickAnalysisFlagCriteria { get; set; }
}
