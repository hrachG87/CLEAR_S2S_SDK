using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskFlagsAddress")]
public class RiskFlagsAddress
{
    [XmlElement("Street")]
    public string Street { get; set; }

    [XmlElement("City")]
    public string City { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

    [XmlElement("Zip")]
    public string Zip { get; set; }

    [XmlElement("County")]
    public string County { get; set; }

    [XmlElement("Country")]
    public string Country { get; set; }
}
