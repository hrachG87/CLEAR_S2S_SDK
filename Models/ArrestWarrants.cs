using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ArrestWarrants")]
public class ArrestWarrants
{
    [XmlElement("ArrestWarrantsFlag")]
    public RiskFlagInfo ArrestWarrantsFlag { get; set; }

}
}