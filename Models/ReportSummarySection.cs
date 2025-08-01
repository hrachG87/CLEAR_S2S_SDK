using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ReportSummarySection")]
public class ReportSummarySection
{
    [XmlElement("ReportSummaryRecord")]
    public List<ReportSummaryRecord> ReportSummaryRecord { get; set; }
}
