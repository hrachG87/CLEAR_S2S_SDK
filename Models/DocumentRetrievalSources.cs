using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DocumentRetrievalSources")]
public class DocumentRetrievalSources
{
    [XmlElement("SourceDocumentGuid")]
    public List<string> SourceDocumentGuid { get; set; }
}
