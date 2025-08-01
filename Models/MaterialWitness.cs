using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MaterialWitness")]
public class MaterialWitness
{
    [XmlElement("MaterialWitnessState")]
    public RiskFlagInfo MaterialWitnessState { get; set; }

    [XmlElement("MaterialWitnessFederal")]
    public RiskFlagInfo MaterialWitnessFederal { get; set; }

}
}