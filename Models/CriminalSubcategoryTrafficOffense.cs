using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalSubcategoryTrafficOffense")]
public class CriminalSubcategoryTrafficOffense
{
    [XmlElement("TransportDangerousMaterial")]
    public CriminalChargetypes TransportDangerousMaterial { get; set; }

    [XmlElement("IgnitionTampering")]
    public CriminalChargetypes IgnitionTampering { get; set; }

    [XmlElement("FailureToMaintainLiabilityInsurance")]
    public CriminalChargetypes FailureToMaintainLiabilityInsurance { get; set; }

    [XmlElement("TrafficOffense")]
    public CriminalChargetypes TrafficOffense { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}
}