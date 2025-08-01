using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformBusinessSearchResponse")]
public class RiskInformBusinessSearchResponse
{
    [XmlElement("Status")]
    public RiskInformBusinessStatus Status { get; set; }

    [XmlElement("riskInformBusinessSearchResult")]
    public RiskInformBusinessSearchResult riskInformBusinessSearchResult { get; set; }

}