using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AidingAbetting")]
public class AidingAbetting
{
    [XmlElement("AidAbetOffense")]
    public RiskFlagInfo AidAbetOffense { get; set; }

}