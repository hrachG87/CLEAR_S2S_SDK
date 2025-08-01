using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GlobalBeneficialOwnershipReportDetails")]
public class GlobalBeneficialOwnershipReportDetails
{
    [XmlElement("Status")]
    public ClearReportApiStatus Status { get; set; }

    [XmlElement("SectionResults")]
    public List<GlobalBeneficialOwnershipSectionResults> SectionResults { get; set; }
}
