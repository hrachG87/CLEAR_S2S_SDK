using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("VehicleDominantValues")]
public class VehicleDominantValues
{
    [XmlElement("VehicleMakeModel")]
    public string VehicleMakeModel { get; set; }

    [XmlElement("VehicleYear")]
    public string VehicleYear { get; set; }

    [XmlElement("LicensePlateNumber")]
    public string LicensePlateNumber { get; set; }

    [XmlElement("LicensePlateState")]
    public string LicensePlateState { get; set; }

    [XmlElement("OwnerName")]
    public string OwnerName { get; set; }

}