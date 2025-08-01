using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OtherBusinessesLinkedToTheBusinessAddressDetails")]
public class OtherBusinessesLinkedToTheBusinessAddressDetails
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("Address")]
    public EidvBusinessSearchAddress Address { get; set; }

}
}