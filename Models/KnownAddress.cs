using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("KnownAddress")]
public class KnownAddress
{
    [XmlElement("Street")]
    public string Street { get; set; }

    [XmlElement("City")]
    public string City { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

    [XmlElement("ZipCode")]
    public string ZipCode { get; set; }

    [XmlElement("County")]
    public string County { get; set; }

    [XmlElement("Source")]
    public List<string> Source { get; set; }

    [XmlElement("LastConfirmed")]
    public string LastConfirmed { get; set; }

    [XmlElement("DocumentIdentifierInfo")]
    public List<EidvPersonSearchDocumentIdentifierInfo> DocumentIdentifierInfo { get; set; }

}