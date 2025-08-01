using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OtherParty")]
public class OtherParty
{
    [XmlElement("PartyInfo")]
    public CourtPartyInfo PartyInfo { get; set; }

}