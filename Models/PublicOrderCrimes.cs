using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PublicOrderCrimes")]
public class PublicOrderCrimes
{
    [XmlElement("PublicOrderCrimesFlag")]
    public RiskFlagInfo PublicOrderCrimesFlag { get; set; }
}
