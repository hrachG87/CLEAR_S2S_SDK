using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OrganizationAddress")]
public class OrganizationAddress
{
    [XmlElement("Street")]
    public string Street { get; set; }

    [XmlElement("City")]
    public string City { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

    [XmlElement("ZipCode")]
    public string ZipCode { get; set; }

    [XmlElement("Country")]
    public string Country { get; set; }

}