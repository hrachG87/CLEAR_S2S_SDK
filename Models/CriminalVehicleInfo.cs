using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalVehicleInfo")]
public class CriminalVehicleInfo
{
    [XmlElement("Make")]
    public string Make { get; set; }

    [XmlElement("Model")]
    public string Model { get; set; }

    [XmlElement("ModelYear")]
    public string ModelYear { get; set; }

    [XmlElement("PlateNumber")]
    public string PlateNumber { get; set; }

    [XmlElement("PlateState")]
    public string PlateState { get; set; }

    [XmlElement("VehicleColor")]
    public string VehicleColor { get; set; }
}
