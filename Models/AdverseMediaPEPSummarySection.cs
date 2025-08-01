using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaPEPSummarySection")]
public class AdverseMediaPEPSummarySection
{
    [XmlElement("AdverseMediaSummaryRecord")]
    public List<AdverseMediaSummaryRecord> AdverseMediaSummaryRecord { get; set; }

    [XmlElement("AdverseMediaSanctionSummaryRecord")]
    public List<SanctionSummaryRecord> AdverseMediaSanctionSummaryRecord { get; set; }

    [XmlElement("AdverseMediaPEPSummaryRecord")]
    public List<PEPSummaryRecord> AdverseMediaPEPSummaryRecord { get; set; }

    [XmlElement("AdverseMediaSOESummaryRecord")]
    public List<SOESummaryRecord> AdverseMediaSOESummaryRecord { get; set; }

}