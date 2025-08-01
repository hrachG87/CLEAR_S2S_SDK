using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Watercraft")]
public class Watercraft
{
    [XmlElement("WatercraftSingle")]
    public RiskFlagInfo WatercraftSingle { get; set; }

    [XmlElement("Watercraft Multiple")]
    public RiskFlagInfo WatercraftMultiple { get; set; }

}
}