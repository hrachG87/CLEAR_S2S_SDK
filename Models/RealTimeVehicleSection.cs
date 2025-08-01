using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RealTimeVehicleSection")]
public class RealTimeVehicleSection
{
    [XmlElement("RealTimeVehicleRecord")]
    public List<RealTimeVehicleRecord> RealTimeVehicleRecord { get; set; }

}