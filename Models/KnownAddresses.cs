using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("KnownAddresses")]
public class KnownAddresses
{
    [XmlElement("KnownAddress")]
    public List<KnownAddress> KnownAddress { get; set; }

}
}