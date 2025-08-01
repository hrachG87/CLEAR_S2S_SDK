using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalSubCategories")]
public class CriminalSubCategories
{
    [XmlElement("FelonyVulnerableVictim")]
    public RiskFlagInfo FelonyVulnerableVictim { get; set; }

}
}