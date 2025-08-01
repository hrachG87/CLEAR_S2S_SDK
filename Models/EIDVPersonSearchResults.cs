using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EIDVPersonSearchResults")]
public class EIDVPersonSearchResults
{
    [XmlElement("eidvpersonSearchResult")]
    public EIDVPersonSearchResult eidvpersonSearchResult { get; set; }
}
