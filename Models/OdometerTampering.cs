using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OdometerTampering")]
public class OdometerTampering
{
    [XmlElement("OdometerTamperingFlag")]
    public RiskFlagInfo OdometerTamperingFlag { get; set; }

}
}