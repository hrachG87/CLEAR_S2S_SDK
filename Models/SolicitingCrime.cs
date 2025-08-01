using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SolicitingCrime")]
public class SolicitingCrime
{
    [XmlElement("SolicitCrime")]
    public RiskFlagInfo SolicitCrime { get; set; }

}