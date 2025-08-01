using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FlightEscape")]
public class FlightEscape
{
    [XmlElement("Escape")]
    public RiskFlagInfo Escape { get; set; }

    [XmlElement("FlightToAvoid")]
    public RiskFlagInfo FlightToAvoid { get; set; }

    [XmlElement("AidPrisonerEscape")]
    public RiskFlagInfo AidPrisonerEscape { get; set; }

    [XmlElement("HarborFugitive")]
    public RiskFlagInfo HarborFugitive { get; set; }

    [XmlElement("FlightEscapeFlag")]
    public RiskFlagInfo FlightEscapeFlag { get; set; }

}
}