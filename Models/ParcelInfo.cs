using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ParcelInfo")]
public class ParcelInfo
{
    [XmlElement("ParcelCount")]
    public string ParcelCount { get; set; }

    [XmlElement("Parcel")]
    public List<Parcel> Parcel { get; set; }
}
