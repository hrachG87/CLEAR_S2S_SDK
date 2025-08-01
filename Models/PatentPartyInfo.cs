using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PatentPartyInfo")]
public class PatentPartyInfo
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("City")]
    public string City { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

}
}