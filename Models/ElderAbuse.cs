using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ElderAbuse")]
public class ElderAbuse
{
    [XmlElement("FinancialExploitVulnerable")]
    public RiskFlagInfo FinancialExploitVulnerable { get; set; }
}
