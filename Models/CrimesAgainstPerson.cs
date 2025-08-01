using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CrimesAgainstPerson")]
public class CrimesAgainstPerson
{
    [XmlElement("CrimesAgainstPersonFlag")]
    public RiskFlagInfo CrimesAgainstPersonFlag { get; set; }
}
