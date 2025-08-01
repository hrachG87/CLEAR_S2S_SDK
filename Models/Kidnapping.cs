using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Kidnapping")]
public class Kidnapping
{
    [XmlElement("KidnapMinorRansom")]
    public RiskFlagInfo KidnapMinorRansom { get; set; }

    [XmlElement("KidnapAdultRansom")]
    public RiskFlagInfo KidnapAdultRansom { get; set; }

    [XmlElement("KidnapMinorSexAssault")]
    public RiskFlagInfo KidnapMinorSexAssault { get; set; }

    [XmlElement("KidnapMinor")]
    public RiskFlagInfo KidnapMinor { get; set; }

    [XmlElement("KidnapAdult")]
    public RiskFlagInfo KidnapAdult { get; set; }

    [XmlElement("KidnapHostageForEscape")]
    public RiskFlagInfo KidnapHostageForEscape { get; set; }

    [XmlElement("AbductionWithoutRansomAssault")]
    public RiskFlagInfo AbductionWithoutRansomAssault { get; set; }

    [XmlElement("KidnapHijackingAircraft")]
    public RiskFlagInfo KidnapHijackingAircraft { get; set; }

    [XmlElement("NonParentKidnapMinor")]
    public RiskFlagInfo NonParentKidnapMinor { get; set; }

    [XmlElement("NonParentFalseImprisonMinor")]
    public RiskFlagInfo NonParentFalseImprisonMinor { get; set; }

    [XmlElement("ParentFalseImprisonMinor")]
    public RiskFlagInfo ParentFalseImprisonMinor { get; set; }

    [XmlElement("InterfereWithCustody")]
    public RiskFlagInfo InterfereWithCustody { get; set; }

    [XmlElement("FalseImprisonNonMinor")]
    public RiskFlagInfo FalseImprisonNonMinor { get; set; }

    [XmlElement("KidnappingFlag")]
    public RiskFlagInfo KidnappingFlag { get; set; }

    [XmlElement("KidnapMinorByParent")]
    public RiskFlagInfo KidnapMinorByParent { get; set; }

    [XmlElement("KidnapAdultSexAssault")]
    public RiskFlagInfo KidnapAdultSexAssault { get; set; }
}
