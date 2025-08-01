using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FalseAlarm")]
public class FalseAlarm
{
    [XmlElement("FalseFireAlarm")]
    public RiskFlagInfo FalseFireAlarm { get; set; }

}