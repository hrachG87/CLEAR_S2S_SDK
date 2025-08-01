using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FactorsLoweringScore")]
public class FactorsLoweringScore
{
    [XmlElement("FactorLoweringScore")]
    public List<string> FactorLoweringScore { get; set; }

}
}