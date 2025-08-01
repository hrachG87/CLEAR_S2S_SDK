using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessAddressUsedAsResidentialAddressDetails")]
public class BusinessAddressUsedAsResidentialAddressDetails
{
    [XmlElement("Address")]
    public EidvBusinessSearchAddress Address { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

}
}