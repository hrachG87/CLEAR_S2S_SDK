using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("VehicleRecordDetailsContainer")]
public class VehicleRecordDetailsContainer
{
    [XmlElement("VehicleResponseDetail")]
    public VehicleResponseDetail VehicleResponseDetail { get; set; }

}
}