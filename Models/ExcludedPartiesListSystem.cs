using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ExcludedPartiesListSystem")]
public class ExcludedPartiesListSystem
{
    [XmlElement("EPLS")]
    public RiskFlagInfo EPLS { get; set; }

}
}