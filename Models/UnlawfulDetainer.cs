using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UnlawfulDetainer")]
public class UnlawfulDetainer
{
    [XmlElement("UnlawfulCivil")]
    public RiskFlagInfo UnlawfulCivil { get; set; }

    [XmlElement("UnlawfulJudge")]
    public RiskFlagInfo UnlawfulJudge { get; set; }

}
}