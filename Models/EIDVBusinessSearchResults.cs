using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EIDVBusinessSearchResults")]
public class EIDVBusinessSearchResults
{
    [XmlElement("EIDVBusinessSearchResult")]
    public EIDVBusinessSearchResult EIDVBusinessSearchResult { get; set; }

}