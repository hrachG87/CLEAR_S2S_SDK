using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Military")]
public class Military
{
    [XmlElement("MilitaryDesertion")]
    public RiskFlagInfo MilitaryDesertion { get; set; }

    [XmlElement("MilitaryFlag")]
    public RiskFlagInfo MilitaryFlag { get; set; }

}
}