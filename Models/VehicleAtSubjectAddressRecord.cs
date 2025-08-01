using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("VehicleAtSubjectAddressRecord")]
public class VehicleAtSubjectAddressRecord
{
    [XmlElement("SubjectAddress")]
    public CommonDataAddress SubjectAddress { get; set; }

    [XmlElement("VehicleRecord")]
    public List<VehicleRecord> VehicleRecord { get; set; }

    [XmlElement("MotorVehicleServiceAndWarranty")]
    public List<MotorVehicleServiceAndWarrantyRecord> MotorVehicleServiceAndWarranty { get; set; }

}