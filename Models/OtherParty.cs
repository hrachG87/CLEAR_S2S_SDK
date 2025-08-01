using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OtherParty")]
public class OtherParty
{
    [XmlElement("PartyInfo")]
    public CourtPartyInfo PartyInfo { get; set; }

}
}