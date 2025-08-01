using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("TopResultMonitorList")]
public class TopResultMonitorList
{
    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("ResultCount")]
    public int ResultCount { get; set; }
}
