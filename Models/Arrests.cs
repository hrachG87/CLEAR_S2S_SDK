using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Arrests")]
public class Arrests
{
    [XmlElement("ArrestsFlag")]
    public RiskFlagInfo ArrestsFlag { get; set; }

}