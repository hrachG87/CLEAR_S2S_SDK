using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Lawsuits")]
public class Lawsuits
{
    [XmlElement("LawsuitsAsDefendantOverAmount")]
    public RiskFlagInfo LawsuitsAsDefendantOverAmount { get; set; }

    [XmlElement("LawsuitsTotalAmount")]
    public RiskFlagInfo LawsuitsTotalAmount { get; set; }

}
}