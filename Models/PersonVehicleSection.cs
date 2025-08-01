using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonVehicleSection")]
public class PersonVehicleSection
{
    [XmlElement("VehicleRecord")]
    public List<VehicleRecord> VehicleRecord { get; set; }
}
