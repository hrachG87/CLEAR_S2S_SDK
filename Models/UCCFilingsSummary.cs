using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("UCCFilingsSummary")]
public class UCCFilingsSummary
{
    [XmlElement("UCCFilingSummaryTotals")]
    public UCCFilingSummaryDetail UCCFilingSummaryTotals { get; set; }

    [XmlElement("UCCFilingSummaryDetail")]
    public List<UCCFilingSummaryDetail> UCCFilingSummaryDetail { get; set; }
}
