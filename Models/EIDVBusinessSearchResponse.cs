using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EIDVBusinessSearchResponse")]
public class EIDVBusinessSearchResponse
{
    [XmlElement("Status")]
    public List<EIDVBusinessSearchResults> Status { get; set; }
}
