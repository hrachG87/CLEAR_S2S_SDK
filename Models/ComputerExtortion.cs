using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ComputerExtortion")]
public class ComputerExtortion
{
    [XmlElement("ExtortionComputerData")]
    public RiskFlagInfo ExtortionComputerData { get; set; }

}