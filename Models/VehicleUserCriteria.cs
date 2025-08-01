using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("VehicleUserCriteria")]
public class VehicleUserCriteria
{
    [XmlElement("VehicleCriteria")]
    public VehicleCriteria VehicleCriteria { get; set; }
}
