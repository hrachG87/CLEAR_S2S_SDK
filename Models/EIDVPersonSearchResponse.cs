using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EIDVPersonSearchResponse")]
public class EIDVPersonSearchResponse
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("EIDVPersonSearchResults")]
    public List<EIDVPersonSearchResults> EIDVPersonSearchResults { get; set; }

}