using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformSummary")]
public class RiskInformSummary
{
    [XmlElement("RiskInformSummaryRecord")]
    public RiskInformSummaryRecord RiskInformSummaryRecord { get; set; }
}
