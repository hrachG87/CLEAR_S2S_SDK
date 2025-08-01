using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PoBoxListedAsAddressDetails")]
public class PoBoxListedAsAddressDetails
{
    [XmlElement("Address")]
    public EidvBusinessSearchAddress Address { get; set; }

}
}