using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("VehicleDatasources")]
public class VehicleDatasources
{
    [XmlElement("PublicRecordVehicle")]
    public string PublicRecordVehicle { get; set; }

    [XmlElement("RealTimeVehicleGateway")]
    public string RealTimeVehicleGateway { get; set; }

    [XmlElement("MotorVehicleServiceAndWarrantyRecords")]
    public string MotorVehicleServiceAndWarrantyRecords { get; set; }

}
}