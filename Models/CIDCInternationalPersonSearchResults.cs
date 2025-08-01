using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CIDCInternationalPersonSearchResults")]
public class CIDCInternationalPersonSearchResults
{
    [XmlElement("CIDCInternationalPersonSearchResult")]
    public CIDCInternationalPersonSearchResult CIDCInternationalPersonSearchResult { get; set; }

}