using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonQuickAnalysisFlagSection")]
public class PersonQuickAnalysisFlagSection
{
    [XmlElement("QuickAnalysisFlagRecord")]
    public List<PersonQuickAnalysisFlagRecord> QuickAnalysisFlagRecord { get; set; }

}