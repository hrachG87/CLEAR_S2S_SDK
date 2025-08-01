using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("JuvenileOffenders")]
public class JuvenileOffenders
{
    [XmlElement("JuvenileEscape")]
    public RiskFlagInfo JuvenileEscape { get; set; }

    [XmlElement("JuvenileParoleAbscond")]
    public RiskFlagInfo JuvenileParoleAbscond { get; set; }

    [XmlElement("Homicide")]
    public RiskFlagInfo Homicide { get; set; }

}
}