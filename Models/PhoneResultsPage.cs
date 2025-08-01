using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PhoneResultsPage")]
public class PhoneResultsPage
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("StartIndex")]
    public int StartIndex { get; set; }

    [XmlElement("EndIndex")]
    public int EndIndex { get; set; }

    [XmlElement("ResultGroup")]
    public List<PhoneSearchResultsGroup> ResultGroup { get; set; }
}
