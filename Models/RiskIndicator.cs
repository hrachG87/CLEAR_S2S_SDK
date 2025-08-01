using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskIndicator")]
public class RiskIndicator
{
    [XmlElement("IndicatorName")]
    public string IndicatorName { get; set; }

    [XmlElement("SourceName")]
    public List<string> SourceName { get; set; }

    [XmlElement("Description")]
    public string Description { get; set; }

    [XmlElement("Country")]
    public List<string> Country { get; set; }

    [XmlElement("DegreeOfRelationship")]
    public string DegreeOfRelationship { get; set; }

    [XmlElement("Score")]
    public string Score { get; set; }

}