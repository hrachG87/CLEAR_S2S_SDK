using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MatchPartyList")]
public class MatchPartyList
{
    [XmlElement("InvolvedAttorney")]
    public List<InvolvedAttorney> InvolvedAttorney { get; set; }

    [XmlElement("InvolvedParty")]
    public List<InvolvedParty> InvolvedParty { get; set; }

    [XmlElement("AKAInfo")]
    public List<CourtDataAKAInfo> AKAInfo { get; set; }
}
