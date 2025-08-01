using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CIDCInternationalPersonSearchResult")]
public class CIDCInternationalPersonSearchResult
{
    [XmlElement("ServiceErrors")]
    public EidvServiceErrors ServiceErrors { get; set; }

    [XmlElement("InternationalPersonEntities")]
    public CIDCInternationalPersonEntities InternationalPersonEntities { get; set; }

    [XmlElement("CIDCInternationalPersonSearchRequest")]
    public CIDCInternationalPersonSearchRequest CIDCInternationalPersonSearchRequest { get; set; }
}
