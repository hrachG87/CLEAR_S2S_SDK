using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GlobalBeneficialOwnershipReportSections")]
public class GlobalBeneficialOwnershipReportSections
{
    [XmlElement("UserTermsSection")]
    public PersonUserTermsSection UserTermsSection { get; set; }

    [XmlElement("SubjectSection")]
    public GlobalBeneficialOwnershipSubjectSection SubjectSection { get; set; }

    [XmlElement("SummarySection")]
    public GlobalBeneficialOwnershipSummarySection SummarySection { get; set; }

    [XmlElement("GlobalBeneficialOwnershipDetailsSection")]
    public GlobalBeneficialOwnershipDetailsSection GlobalBeneficialOwnershipDetailsSection { get; set; }

    [XmlElement("SourceDocumentsSection")]
    public GlobalBeneficialOwnershipSourceDocumentsSection SourceDocumentsSection { get; set; }

    [XmlElement("PermissiblePurposeSection")]
    public PersonPermissiblePurposeSection PermissiblePurposeSection { get; set; }

    [XmlElement("SourceDocumentRecord")]
    public GlobalBeneficialOwnershipSourceDocumentsRecord SourceDocumentRecord { get; set; }

    [XmlElement("FcraSection")]
    public FcraSection FcraSection { get; set; }

}