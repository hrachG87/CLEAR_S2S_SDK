using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SeriousCriminalTrafficOffenses")]
public class SeriousCriminalTrafficOffenses
{
    [XmlElement("HitAndRun")]
    public RiskFlagInfo HitAndRun { get; set; }

}
}