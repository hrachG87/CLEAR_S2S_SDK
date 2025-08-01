using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportAddressRecord")]
public class PersonReportAddressRecord
{
    [XmlElement("AddressInfo")]
    public List<PersonReportAddressInfo> AddressInfo { get; set; }

}
}