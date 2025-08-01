using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AddressSection")]
public class AddressSection
{
    [XmlElement("AddressRecord")]
    public List<PersonReportAddressRecord> AddressRecord { get; set; }

}
}