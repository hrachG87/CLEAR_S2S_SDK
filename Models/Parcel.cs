using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Parcel")]
public class Parcel
{
    [XmlElement("AirRights")]
    public string AirRights { get; set; }

    [XmlElement("BlockNumber")]
    public string BlockNumber { get; set; }

    [XmlElement("LotBorough")]
    public string LotBorough { get; set; }

    [XmlElement("LotNumber")]
    public string LotNumber { get; set; }

    [XmlElement("ParcelAddressUnit")]
    public string ParcelAddressUnit { get; set; }

    [XmlElement("ParcelHouseNumber")]
    public string ParcelHouseNumber { get; set; }

    [XmlElement("ParcelStreetName")]
    public string ParcelStreetName { get; set; }

    [XmlElement("PartialLot")]
    public string PartialLot { get; set; }

    [XmlElement("PropertyType")]
    public string PropertyType { get; set; }
}
