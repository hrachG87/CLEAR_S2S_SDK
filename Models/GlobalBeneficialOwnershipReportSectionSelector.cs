using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GlobalBeneficialOwnershipReportSectionSelector")]
public class GlobalBeneficialOwnershipReportSectionSelector
{
    [XmlElement("GlobalBeneficialOwnershipSubjectSection")]
    public bool GlobalBeneficialOwnershipSubjectSection { get; set; }

    [XmlElement("GlobalBeneficialOwnershipSummarySection")]
    public bool GlobalBeneficialOwnershipSummarySection { get; set; }

    [XmlElement("GlobalBeneficialOwnershipDetailsSection")]
    public bool GlobalBeneficialOwnershipDetailsSection { get; set; }

    [XmlElement("GlobalBeneficialOwnershipSourceDocumentsSection")]
    public bool GlobalBeneficialOwnershipSourceDocumentsSection { get; set; }

}