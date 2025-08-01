using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Plaintiff")]
public class Plaintiff
{
    [XmlElement("PlaintiffDemandAmount")]
    public string PlaintiffDemandAmount { get; set; }

    [XmlElement("RemedyDemandInfo")]
    public List<RemedyDemandInfo> RemedyDemandInfo { get; set; }

    [XmlElement("PartyInfo")]
    public CourtPartyInfo PartyInfo { get; set; }
}
