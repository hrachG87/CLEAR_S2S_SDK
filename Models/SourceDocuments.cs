using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SourceDocuments")]
public class SourceDocuments
{
    [XmlElement("SourceName")]
    public string SourceName { get; set; }

    [XmlElement("SourceDocumentCount")]
    public int SourceDocumentCount { get; set; }

    [XmlElement("SourceDocument")]
    public List<GlobalBeneficialOwnershipSourceDocumentsRecord> SourceDocument { get; set; }
}
