using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIPersonReportSummaryRecord")]
public class RIPersonReportSummaryRecord
{
    [XmlElement("sections")]
    public RIPersonReportSections sections { get; set; }

    [XmlElement("TotalScore")]
    public string TotalScore { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

}