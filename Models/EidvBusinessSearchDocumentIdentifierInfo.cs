using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EidvBusinessSearchDocumentIdentifierInfo")]
public class EidvBusinessSearchDocumentIdentifierInfo
{
    [XmlElement("DocumentIdentifier")]
    public string DocumentIdentifier { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

}