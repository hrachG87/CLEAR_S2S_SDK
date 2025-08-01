using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonalAddresses")]
public class PersonalAddresses
{
    [XmlElement("Address")]
    public List<CommonDataAddress> Address { get; set; }

    [XmlElement("Region")]
    public string Region { get; set; }

    [XmlElement("Location")]
    public string Location { get; set; }

    [XmlElement("Country")]
    public List<string> Country { get; set; }
}
