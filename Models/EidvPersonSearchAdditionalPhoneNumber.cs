using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EidvPersonSearchAdditionalPhoneNumber")]
public class EidvPersonSearchAdditionalPhoneNumber
{
    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("Source")]
    public List<string> Source { get; set; }

    [XmlElement("DocumentIdentifierInfo")]
    public List<EidvPersonSearchDocumentIdentifierInfo> DocumentIdentifierInfo { get; set; }
}
