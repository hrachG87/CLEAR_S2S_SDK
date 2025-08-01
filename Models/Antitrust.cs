using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Antitrust")]
public class Antitrust
{
    [XmlElement("AntitrustFlag")]
    public RiskFlagInfo AntitrustFlag { get; set; }

}
}