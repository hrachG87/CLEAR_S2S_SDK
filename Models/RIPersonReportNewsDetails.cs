using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RIPersonReportNewsDetails")]
public class RIPersonReportNewsDetails
{
    [XmlElement("newsRecord")]
    public List<NewsResults> newsRecord { get; set; }
}
