using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaReportSectionDetails")]
public class AdverseMediaReportSectionDetails
{
    [XmlElement("SanctionsSummarySection")]
    public AdverseMediaSanctionSummarySection SanctionsSummarySection { get; set; }

    [XmlElement("AdverseMediaSummarySection")]
    public AdverseMediaSummarySection AdverseMediaSummarySection { get; set; }

    [XmlElement("AdverseMediaArticlesSection")]
    public AdverseMediaArticlesSection AdverseMediaArticlesSection { get; set; }

    [XmlElement("FcraSection")]
    public FcraSection FcraSection { get; set; }

    [XmlElement("UserTermsSection")]
    public AdverseMediaUserTermsSection UserTermsSection { get; set; }

    [XmlElement("PoliticallyExposedPersonSection")]
    public PoliticallyExposedPersonSection PoliticallyExposedPersonSection { get; set; }

    [XmlElement("SanctionSection")]
    public SanctionSection SanctionSection { get; set; }

    [XmlElement("StateOwnedEntitySection")]
    public StateOwnedEntitySection StateOwnedEntitySection { get; set; }

    [XmlElement("PEPSummarySection")]
    public AdverseMediaPEPSummarySection PEPSummarySection { get; set; }

    [XmlElement("SOESummarySection")]
    public AdverseMediaSOESummarySection SOESummarySection { get; set; }

}
}