using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FalseAlarm")]
public class FalseAlarm
{
    [XmlElement("FalseFireAlarm")]
    public RiskFlagInfo FalseFireAlarm { get; set; }

}
}