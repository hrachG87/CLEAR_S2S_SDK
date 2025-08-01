using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CodeViolation")]
public class CodeViolation
{
    [XmlElement("HousingCodeViolation")]
    public RiskFlagInfo HousingCodeViolation { get; set; }

    [XmlElement("ZoningCodeViolation")]
    public RiskFlagInfo ZoningCodeViolation { get; set; }

}
}