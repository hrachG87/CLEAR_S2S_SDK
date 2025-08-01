using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("UCCFilingsSummarySection")]
public class UCCFilingsSummarySection
{
    [XmlElement("UCCFilingsSummaryRecord")]
    public List<UCCFilingsSummaryRecord> UCCFilingsSummaryRecord { get; set; }
}
