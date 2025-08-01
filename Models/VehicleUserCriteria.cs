using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("VehicleUserCriteria")]
public class VehicleUserCriteria
{
    [XmlElement("VehicleCriteria")]
    public VehicleCriteria VehicleCriteria { get; set; }

}
}