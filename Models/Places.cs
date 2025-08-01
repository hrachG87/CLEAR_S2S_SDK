using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Places")]
public class Places
{
    [XmlElement("AddressPlaces")]
    public List<string> AddressPlaces { get; set; }

}
}