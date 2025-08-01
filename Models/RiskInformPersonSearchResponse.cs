using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformPersonSearchResponse")]
public class RiskInformPersonSearchResponse
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("RiskInformPersonSearchResult")]
    public RiskInformPersonSearchResult RiskInformPersonSearchResult { get; set; }

}