using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Truancy")]
public class Truancy
{
    [XmlElement("TruancyFlag")]
    public RiskFlagInfo TruancyFlag { get; set; }

}
}