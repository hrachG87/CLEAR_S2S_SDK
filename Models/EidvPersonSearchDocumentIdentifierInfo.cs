using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EidvPersonSearchDocumentIdentifierInfo")]
public class EidvPersonSearchDocumentIdentifierInfo
{
    [XmlElement("DocumentIdentifier")]
    public string DocumentIdentifier { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }
}
