using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskSeverity")]
public class RiskSeverity
{
    [XmlElement("riskIndicator")]
    public List<RiskIndicator> riskIndicator { get; set; }

}
}