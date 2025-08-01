using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonQuickAnalysisSearchResultsGroup")]
public class PersonQuickAnalysisSearchResultsGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("recordDetails")]
    public PersonQuickAnalysisFlagResponseDetailContainer recordDetails { get; set; }

}