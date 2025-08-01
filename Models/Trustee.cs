using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Trustee")]
public class Trustee
{
    [XmlElement("PartyInfo")]
    public CourtPartyInfo PartyInfo { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

}
}