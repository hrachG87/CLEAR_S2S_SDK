using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RealPropertyResultsPage")]
public class RealPropertyResultsPage
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("StartIndex")]
    public int StartIndex { get; set; }

    [XmlElement("EndIndex")]
    public int EndIndex { get; set; }

    [XmlElement("ResultGroup")]
    public List<RealPropertySearchResultsGroup> ResultGroup { get; set; }

}