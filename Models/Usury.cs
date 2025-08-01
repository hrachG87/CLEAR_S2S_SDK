using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Usury")]
public class Usury
{
    [XmlElement("UsuryFlag")]
    public RiskFlagInfo UsuryFlag { get; set; }

}
}