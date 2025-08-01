using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformSummaryRecord")]
public class RiskInformSummaryRecord
{
    [XmlElement("Sections")]
    public Sections Sections { get; set; }

    [XmlElement("TotalScore")]
    public string TotalScore { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

}