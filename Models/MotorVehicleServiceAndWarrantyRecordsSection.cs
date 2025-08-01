using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MotorVehicleServiceAndWarrantyRecordsSection")]
public class MotorVehicleServiceAndWarrantyRecordsSection
{
    [XmlElement("MotorVehicleServiceAndWarrantyRecord")]
    public List<MotorVehicleServiceAndWarrantyRecord> MotorVehicleServiceAndWarrantyRecord { get; set; }
}
