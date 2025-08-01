using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FireworksOffenses")]
public class FireworksOffenses
{
    [XmlElement("FireworksViolation")]
    public RiskFlagInfo FireworksViolation { get; set; }

}