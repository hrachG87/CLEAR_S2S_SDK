using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformAddressDetails")]
public class RiskInformAddressDetails
{
    [XmlElement("AddressRecord")]
    public RIBusinessReportAddressRecord AddressRecord { get; set; }

}
}