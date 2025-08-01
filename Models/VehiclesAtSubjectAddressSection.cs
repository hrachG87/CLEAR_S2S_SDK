using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("VehiclesAtSubjectAddressSection")]
public class VehiclesAtSubjectAddressSection
{
    [XmlElement("VehicleAtSubjectAddressRecord")]
    public List<VehicleAtSubjectAddressRecord> VehicleAtSubjectAddressRecord { get; set; }

}
}