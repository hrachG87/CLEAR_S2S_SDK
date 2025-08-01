using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FireworksOffenses")]
public class FireworksOffenses
{
    [XmlElement("FireworksViolation")]
    public RiskFlagInfo FireworksViolation { get; set; }

}
}