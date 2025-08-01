using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonVehicleSection")]
public class PersonVehicleSection
{
    [XmlElement("VehicleRecord")]
    public List<VehicleRecord> VehicleRecord { get; set; }

}
}