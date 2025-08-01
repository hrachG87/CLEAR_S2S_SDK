using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonPlaces")]
public class PersonPlaces
{
    [XmlElement("PersonAge")]
    public string PersonAge { get; set; }

    [XmlElement("AddressPlaces")]
    public string AddressPlaces { get; set; }

    [XmlElement("TotalAdditionalPlaces")]
    public string TotalAdditionalPlaces { get; set; }

}
}