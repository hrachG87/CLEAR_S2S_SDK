using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonResultsPageV3")]
public class PersonResultsPageV3
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("StartIndex")]
    public int StartIndex { get; set; }

    [XmlElement("EndIndex")]
    public int EndIndex { get; set; }

    [XmlElement("ResultGroup")]
    public List<ResultGroup> ResultGroup { get; set; }

}