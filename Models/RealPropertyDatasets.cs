using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RealPropertyDatasets")]
public class RealPropertyDatasets
{
    [XmlElement("RealPropertyDeeds")]
    public string RealPropertyDeeds { get; set; }

    [XmlElement("RealPropertyForeclosures")]
    public string RealPropertyForeclosures { get; set; }

    [XmlElement("RealPropertyTaxRolls")]
    public string RealPropertyTaxRolls { get; set; }

}
}