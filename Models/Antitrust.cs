using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Antitrust")]
public class Antitrust
{
    [XmlElement("AntitrustFlag")]
    public RiskFlagInfo AntitrustFlag { get; set; }
}
