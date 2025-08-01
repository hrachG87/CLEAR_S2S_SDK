using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Trespassing")]
public class Trespassing
{
    [XmlElement("TrespassHuntFishPrivate")]
    public RiskFlagInfo TrespassHuntFishPrivate { get; set; }

}