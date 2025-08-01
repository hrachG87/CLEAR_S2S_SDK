using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Truancy")]
public class Truancy
{
    [XmlElement("TruancyFlag")]
    public RiskFlagInfo TruancyFlag { get; set; }
}
