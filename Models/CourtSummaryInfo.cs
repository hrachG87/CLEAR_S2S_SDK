using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CourtSummaryInfo")]
public class CourtSummaryInfo
{
    [XmlElement("DocumentGuid")]
    public string DocumentGuid { get; set; }

    [XmlElement("TotalPageCount")]
    public string TotalPageCount { get; set; }

    [XmlElement("DocketsDetailsUri")]
    public string DocketsDetailsUri { get; set; }
}
