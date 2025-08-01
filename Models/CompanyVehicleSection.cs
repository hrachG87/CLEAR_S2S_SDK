using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyVehicleSection")]
public class CompanyVehicleSection
{
    [XmlElement("VehicleRecord")]
    public List<VehicleRecord> VehicleRecord { get; set; }

}