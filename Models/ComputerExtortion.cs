using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ComputerExtortion")]
public class ComputerExtortion
{
    [XmlElement("ExtortionComputerData")]
    public RiskFlagInfo ExtortionComputerData { get; set; }

}
}