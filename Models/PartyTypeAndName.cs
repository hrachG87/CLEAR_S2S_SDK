using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PartyTypeAndName")]
public class PartyTypeAndName
{
    [XmlElement("PartyName")]
    public List<string> PartyName { get; set; }

    [XmlElement("TypeOfParty")]
    public string TypeOfParty { get; set; }

}
}