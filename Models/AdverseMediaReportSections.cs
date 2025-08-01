using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaReportSections")]
public class AdverseMediaReportSections
{
    [XmlElement("AdverseMediaSanctionsSummarySection")]
    public bool AdverseMediaSanctionsSummarySection { get; set; }

    [XmlElement("AdverseMediaPEPSummarySection")]
    public bool AdverseMediaPEPSummarySection { get; set; }

    [XmlElement("AdverseMediaSOESummarySection")]
    public bool AdverseMediaSOESummarySection { get; set; }

    [XmlElement("AdverseMediaSummarySection")]
    public bool AdverseMediaSummarySection { get; set; }

    [XmlElement("ArticlesSection")]
    public bool ArticlesSection { get; set; }

    [XmlElement("PoliticallyExposedPersonSection")]
    public bool PoliticallyExposedPersonSection { get; set; }

    [XmlElement("SanctionSection")]
    public bool SanctionSection { get; set; }

    [XmlElement("StateOwnedEntitySection")]
    public bool StateOwnedEntitySection { get; set; }
}
