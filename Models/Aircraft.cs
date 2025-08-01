using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Aircraft")]
public class Aircraft
{
    [XmlElement("AircraftSingle")]
    public RiskFlagInfo AircraftSingle { get; set; }

    [XmlElement("AircraftMultiple")]
    public RiskFlagInfo AircraftMultiple { get; set; }

}