using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AddressInfo")]
public class AddressInfo
{
    [XmlElement("Street")]
    public string Street { get; set; }

    [XmlElement("StreetNumber")]
    public string StreetNumber { get; set; }

    [XmlElement("City")]
    public string City { get; set; }

    [XmlElement("StateOrTerritory")]
    public string StateOrTerritory { get; set; }

    [XmlElement("Zip")]
    public string Zip { get; set; }

    [XmlElement("FullAddress")]
    public string FullAddress { get; set; }

    [XmlElement("ValidSinceDate")]
    public string ValidSinceDate { get; set; }

}