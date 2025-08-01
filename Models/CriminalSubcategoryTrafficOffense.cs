using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
