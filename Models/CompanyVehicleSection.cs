using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyVehicleSection")]
public class CompanyVehicleSection
{
    [XmlElement("VehicleRecord")]
    public List<VehicleRecord> VehicleRecord { get; set; }

}
}