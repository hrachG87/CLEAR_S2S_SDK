using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonReportAddressDetails")]
public class RIPersonReportAddressDetails
{
    [XmlElement("addressRecord")]
    public AddressRecord addressRecord { get; set; }

}
}