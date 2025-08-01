using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SourceInfo")]
public class SourceInfo
{
    [XmlElement("SourceName")]
    public List<string> SourceName { get; set; }

    [XmlElement("FirstReportedDate")]
    public List<string> FirstReportedDate { get; set; }

    [XmlElement("LastReportedDate")]
    public List<string> LastReportedDate { get; set; }

}