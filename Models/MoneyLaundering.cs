using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MoneyLaundering")]
public class MoneyLaundering
{
    [XmlElement("MoneyLaunderingRemarks")]
    public RiskFlagInfo MoneyLaunderingRemarks { get; set; }

    [XmlElement("MoneyLaunderingTaxBased")]
    public RiskFlagInfo MoneyLaunderingTaxBased { get; set; }

}
}