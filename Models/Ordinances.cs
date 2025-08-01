using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Ordinances")]
public class Ordinances
{
    [XmlElement("MunicipalOrdinance")]
    public RiskFlagInfo MunicipalOrdinance { get; set; }

    [XmlElement("CountyOrdinance")]
    public RiskFlagInfo CountyOrdinance { get; set; }

}
}