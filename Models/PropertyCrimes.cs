using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PropertyCrimes")]
public class PropertyCrimes
{
    [XmlElement("PropertyCrimesRemarks")]
    public RiskFlagInfo PropertyCrimesRemarks { get; set; }

}