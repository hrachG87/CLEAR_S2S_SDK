using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ElderAbuse")]
public class ElderAbuse
{
    [XmlElement("FinancialExploitVulnerable")]
    public RiskFlagInfo FinancialExploitVulnerable { get; set; }

}
}