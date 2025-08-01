using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MultipleSSNsDetails")]
public class MultipleSSNsDetails
{
    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("Source")]
    public List<string> Source { get; set; }

    [XmlElement("DocumentIdentifierInfo")]
    public List<EidvPersonSearchDocumentIdentifierInfo> DocumentIdentifierInfo { get; set; }
}
