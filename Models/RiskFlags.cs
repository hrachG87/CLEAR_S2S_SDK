using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskFlags")]
public class RiskFlags
{
    [XmlElement("RealTimeIncarcerationAndArrest")]
    public string RealTimeIncarcerationAndArrest { get; set; }

}
}