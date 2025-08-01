using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Delivery")]
public class Delivery
{
    [XmlElement("EmailFrequency")]
    public string EmailFrequency { get; set; }

    [XmlElement("InformNoResults")]
    public bool InformNoResults { get; set; }

    [XmlElement("EmailAddresses")]
    public EmailAddresses EmailAddresses { get; set; }
}
