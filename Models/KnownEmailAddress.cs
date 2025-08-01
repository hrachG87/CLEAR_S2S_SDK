using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("KnownEmailAddress")]
public class KnownEmailAddress
{
    [XmlElement("EmailAdress")]
    public string EmailAdress { get; set; }

    [XmlElement("Source")]
    public List<string> Source { get; set; }

    [XmlElement("DocumentIdentifierInfo")]
    public List<EidvPersonSearchDocumentIdentifierInfo> DocumentIdentifierInfo { get; set; }

}