using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GlobalBeneficialOwnershipSourceDocumentsSection")]
public class GlobalBeneficialOwnershipSourceDocumentsSection
{
    [XmlElement("SourceDocumentRecord")]
    public List<GlobalBeneficialOwnershipSourceDocumentsRecord> SourceDocumentRecord { get; set; }
}
