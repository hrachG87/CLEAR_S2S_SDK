using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("VehicleRecordDetailsContainer")]
public class VehicleRecordDetailsContainer
{
    [XmlElement("VehicleResponseDetail")]
    public VehicleResponseDetail VehicleResponseDetail { get; set; }
}
