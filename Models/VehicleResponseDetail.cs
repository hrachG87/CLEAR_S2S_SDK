using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("VehicleResponseDetail")]
public class VehicleResponseDetail
{
    [XmlElement("VehicleRecord")]
    public List<VehicleRecord> VehicleRecord { get; set; }

    [XmlElement("RealTimeVehicleRecord")]
    public List<RealTimeVehicleRecord> RealTimeVehicleRecord { get; set; }

    [XmlElement("DocumentGuids")]
    public List<Sources> DocumentGuids { get; set; }

    [XmlElement("MotorVehicleServiceAndWarrantyRecord")]
    public List<MotorVehicleServiceAndWarrantyRecord> MotorVehicleServiceAndWarrantyRecord { get; set; }

}