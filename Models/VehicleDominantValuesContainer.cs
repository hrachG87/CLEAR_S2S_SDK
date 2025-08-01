using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("VehicleDominantValuesContainer")]
public class VehicleDominantValuesContainer
{
    [XmlElement("VehicleDominantValues")]
    public VehicleDominantValues VehicleDominantValues { get; set; }
}
