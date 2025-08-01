using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Arrests")]
public class Arrests
{
    [XmlElement("ArrestsFlag")]
    public RiskFlagInfo ArrestsFlag { get; set; }

}
}