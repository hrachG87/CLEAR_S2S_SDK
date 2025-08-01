using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("MoralsDecencyCrimes")]
public class MoralsDecencyCrimes
{
    [XmlElement("MoralsCrimes")]
    public RiskFlagInfo MoralsCrimes { get; set; }

}