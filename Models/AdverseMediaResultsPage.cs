using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaResultsPage")]
public class AdverseMediaResultsPage
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("SearchId")]
    public string SearchId { get; set; }

    [XmlElement("StartIndex")]
    public int StartIndex { get; set; }

    [XmlElement("EndIndex")]
    public int EndIndex { get; set; }

    [XmlElement("ResultGroup")]
    public List<AdverseMediaResultGroup> ResultGroup { get; set; }

}