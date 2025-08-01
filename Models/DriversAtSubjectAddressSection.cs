using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DriversAtSubjectAddressSection")]
public class DriversAtSubjectAddressSection
{
    [XmlElement("DriverAtSubjectAddressRecord")]
    public List<DriverAtSubjectAddressRecord> DriverAtSubjectAddressRecord { get; set; }

}
}