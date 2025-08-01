using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonQuickAnalysisFlagResultsPage")]
public class PersonQuickAnalysisFlagResultsPage
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("StartIndex")]
    public int StartIndex { get; set; }

    [XmlElement("EndIndex")]
    public int EndIndex { get; set; }

    [XmlElement("ResultGroup")]
    public List<PersonQuickAnalysisSearchResultsGroup> ResultGroup { get; set; }

}