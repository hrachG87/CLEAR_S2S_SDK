using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("VehicleDominantValuesContainer")]
public class VehicleDominantValuesContainer
{
    [XmlElement("VehicleDominantValues")]
    public VehicleDominantValues VehicleDominantValues { get; set; }

}
}