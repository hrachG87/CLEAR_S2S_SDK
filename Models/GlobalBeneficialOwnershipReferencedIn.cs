using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GlobalBeneficialOwnershipReferencedIn")]
public class GlobalBeneficialOwnershipReferencedIn
{
    [XmlElement("SourceDocuments")]
    public List<SourceDocuments> SourceDocuments { get; set; }
}
