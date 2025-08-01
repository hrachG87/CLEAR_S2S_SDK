using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ElectionLaws")]
public class ElectionLaws
{
    [XmlElement("ElectionLawsFlag")]
    public RiskFlagInfo ElectionLawsFlag { get; set; }

}
}