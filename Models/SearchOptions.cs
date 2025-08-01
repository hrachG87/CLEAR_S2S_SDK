using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SearchOptions")]
public class SearchOptions
{
    [XmlElement("OnlyHeadlineAndLeadPara")]
    public bool OnlyHeadlineAndLeadPara { get; set; }
}
