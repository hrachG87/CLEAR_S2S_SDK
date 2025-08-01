using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CivilRightsViolation")]
public class CivilRightsViolation
{
    [XmlElement("CivilRights")]
    public RiskFlagInfo CivilRights { get; set; }

}
}