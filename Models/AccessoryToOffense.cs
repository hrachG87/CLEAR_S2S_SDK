using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AccessoryToOffense")]
public class AccessoryToOffense
{
    [XmlElement("AccessoryToOffenseFlag")]
    public RiskFlagInfo AccessoryToOffenseFlag { get; set; }
}
